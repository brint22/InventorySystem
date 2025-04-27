using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Infrastracture.SQL
{
    public static class EmployeeSQL
    {
    
        public static string GetListOfEmployees = @"
        SELECT e.EmployeeID, 
            (e.FirstName + ' ' + 
            ISNULL(e.MiddleName + ' ', '') +
            e.LastName + ' ' + 
            ISNULL(e.NameExtension, '')) AS EmployeeName,
        
            FORMAT(e.DateOfBirth, 'MMMM dd, yyyy') AS DateOfBirth,
        
            (
                ISNULL('Barangay ' + a.BarangayName + ', ', '') +
                ISNULL(a.MunicipalityName + ', ', '') +
                ISNULL(a.ProvinceName + ', ', '') +
                ISNULL(CAST(a.ZipCodeNumber AS VARCHAR) + ', ', '') +
                ISNULL(a.CountryName, '')
            ) AS Address,

            r.RoleID,
            UPPER(LEFT(r.RoleName, 1)) + LOWER(SUBSTRING(r.RoleName, 2, LEN(r.RoleName))) AS RoleName,
            ei.ImageData,
        
            CAST(
                DATEDIFF(YEAR, e.DateOfBirth, CAST(GETDATE() AS DATE)) - 
                CASE 
                    WHEN MONTH(e.DateOfBirth) > MONTH(CAST(GETDATE() AS DATE)) 
                        OR (MONTH(e.DateOfBirth) = MONTH(CAST(GETDATE() AS DATE)) 
                        AND DAY(e.DateOfBirth) > DAY(CAST(GETDATE() AS DATE))) 
                    THEN 1 ELSE 0 
                END 
            AS VARCHAR) + ' years old' AS Age,                   

            e.PhoneNumber,
            FORMAT(e.DateHired, 'MMMM dd, yyyy') AS DateHired,
            e.Gender,
            e.CivilStatus

        FROM Employee e
        LEFT JOIN EmployeeImage ei ON e.ImageID = ei.ImageID
        LEFT JOIN Role r ON e.RoleID = r.RoleID
        LEFT JOIN Address a ON e.AddressID = a.AddressID
        WHERE (@RoleFilter = 'All' OR r.RoleName = @RoleFilter)
        ORDER BY EmployeeID;";

        public static string InsertEmployee = @"
        INSERT INTO Employee 
        (EmployeeID, FirstName, MiddleName, LastName, NameExtension, Gender, CivilStatus, DateOfBirth, Age,
        PhoneNumber, DateHired, AddressID, RoleID, ImageID)
        VALUES 
        (@EmployeeID, @FirstName, @MiddleName, @LastName, @NameExtension, @Gender, @CivilStatus, @DateOfBirth,
        DATEDIFF(YEAR, @DateOfBirth, CAST(GETDATE() AS DATE)) - 
        CASE 
        WHEN MONTH(@DateOfBirth) > MONTH(GETDATE()) 
        OR (MONTH(@DateOfBirth) = MONTH(GETDATE()) AND DAY(@DateOfBirth) > DAY(GETDATE()))
        THEN 1 ELSE 0 
                END,
             @PhoneNumber, @DateHired, @AddressID, @RoleID, @ImageID)";

        public static string InsertEmployeeImage = @"
        INSERT INTO EmployeeImage (ImageData)
        OUTPUT INSERTED.ImageID
        VALUES (@ImageData)";

        public static string InsertAddress = @"
        INSERT INTO Address (BarangayName, MunicipalityName, ProvinceName, ZipCodeNumber, CountryName)
        OUTPUT INSERTED.AddressID
        VALUES (@BarangayName, @MunicipalityName, @ProvinceName, @ZipCodeNumber, @CountryName)";

        public const string GetLocationsByAvailability = @"
        SELECT 
            l.LocationID, 
            l.ProductID, 
            l.Availability
        FROM Location l     
        WHERE l.Availability = @Availability;";

    }
}
