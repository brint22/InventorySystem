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
        }



    }
