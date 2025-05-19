using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Infrastracture.SQL
{
    public class ProductSQL
    {

        public static string UpdateLocationQuery = @"
        UPDATE Location 
        SET LocationStart = @Start,
            LocationFinish = @Finish,
            Availability = @Availability
        WHERE LocationID = @LocationID";

        public static string GetAllLocations = @"
       SELECT 
            l.[LocationID],
            l.ProductID,
            l.Availability,
            CASE 
                WHEN ISNULL(l.Capacity, 0) = 0 THEN ''
                ELSE CAST(ISNULL(l.Capacity, 0) AS VARCHAR(50)) + '/' + CAST(ISNULL(p.Capacity, 0) AS VARCHAR(50))
            END AS Capacity,
            CASE 
                WHEN ISNULL(p.Capacity, 0) - ISNULL(l.Capacity, 0) = 0 AND ISNULL(l.Capacity, 0) <> 0 THEN 'Full'
                WHEN ISNULL(l.Capacity, 0) = 0 THEN ''
                ELSE CAST((ISNULL(p.Capacity, 0) - ISNULL(l.Capacity, 0)) AS VARCHAR)
            END AS AvailableCapacity
        FROM [WAREHOUSEISDB].[dbo].[Location] l
        LEFT JOIN Product p ON l.ProductID = p.ProductID
        ORDER BY 
            LEFT(l.LocationID, CHARINDEX('-', l.LocationID) - 1),
            CAST(SUBSTRING(l.LocationID, CHARINDEX('-', l.LocationID) + 1, CHARINDEX('-', l.LocationID, CHARINDEX('-', l.LocationID) + 1) - CHARINDEX('-', l.LocationID) - 1) AS INT),
            CAST(SUBSTRING(l.LocationID, CHARINDEX('-', l.LocationID, CHARINDEX('-', l.LocationID) + 1) + 1, LEN(l.LocationID)) AS INT); ";

        public static string InsertLocation = @"
        INSERT INTO Location (LocationID, ProductID, Availability) 
        VALUES (@LocationID, '', 'Available')";

        public const string GetLocationsByAvailability = @"
SELECT 
    l.[LocationID],
    l.ProductID,
    l.Availability,
    CASE 
        WHEN ISNULL(l.Capacity, 0) = 0 THEN ''
        ELSE CAST(ISNULL(l.Capacity, 0) AS VARCHAR(50)) + '/' + CAST(ISNULL(p.Capacity, 0) AS VARCHAR(50))
    END AS Capacity,
    CASE 
        WHEN ISNULL(p.Capacity, 0) - ISNULL(l.Capacity, 0) = 0 AND ISNULL(l.Capacity, 0) <> 0 THEN 'Full'
        WHEN ISNULL(l.Capacity, 0) = 0 THEN ''
        ELSE CAST((ISNULL(p.Capacity, 0) - ISNULL(l.Capacity, 0)) AS VARCHAR)
    END AS AvailableCapacity
FROM [WAREHOUSEISDB].[dbo].[Location] l
LEFT JOIN Product p ON l.ProductID = p.ProductID
WHERE l.Availability = @Availability -- <======= THIS !!!
ORDER BY 
    LEFT(l.LocationID, CHARINDEX('-', l.LocationID) - 1),
    CAST(SUBSTRING(l.LocationID, CHARINDEX('-', l.LocationID) + 1, CHARINDEX('-', l.LocationID, CHARINDEX('-', l.LocationID) + 1) - CHARINDEX('-', l.LocationID) - 1) AS INT),
    CAST(SUBSTRING(l.LocationID, CHARINDEX('-', l.LocationID, CHARINDEX('-', l.LocationID) + 1) + 1, LEN(l.LocationID)) AS INT);";


        public const string GetLocationsByGroup = @"
        SELECT 
            l.LocationID, 
            l.ProductID, 
            l.Availability,
            CASE 
                WHEN ISNULL(l.Capacity, 0) = 0 THEN ''
                ELSE CAST(ISNULL(l.Capacity, 0) AS VARCHAR(50)) + '/' + CAST(ISNULL(p.Capacity, 0) AS VARCHAR(50))
            END AS Capacity,
            CASE 
                WHEN ISNULL(p.Capacity, 0) - ISNULL(l.Capacity, 0) = 0 AND ISNULL(l.Capacity, 0) <> 0 THEN 'Full'
                WHEN ISNULL(l.Capacity, 0) = 0 THEN ''
                ELSE CAST((ISNULL(p.Capacity, 0) - ISNULL(l.Capacity, 0)) AS VARCHAR)
            END AS AvailableCapacity
            
        FROM Location l
        LEFT JOIN Product p ON l.ProductID = p.ProductID
        WHERE LEFT(l.LocationID, 1) = @GroupLetter
        ORDER BY 
            CAST(SUBSTRING(l.LocationID, CHARINDEX('-', l.LocationID) + 1, CHARINDEX('-', l.LocationID, CHARINDEX('-', l.LocationID) + 1) - CHARINDEX('-', l.LocationID) - 1) AS INT),
            CAST(SUBSTRING(l.LocationID, CHARINDEX('-', l.LocationID, CHARINDEX('-', l.LocationID) + 1) + 1, LEN(l.LocationID)) AS INT);
        ";
        
    public const string CheckIfProductExists = @"
        SELECT COUNT(*) FROM Product WHERE ProductName = @ProductName";

        public const string GetMaxProductNumber = @"
        SELECT MAX(CAST(SUBSTRING(ProductID, 2, 4) AS INT))
        FROM Product
        WHERE ProductID LIKE @Prefix";

        public const string InsertProduct = @"
        INSERT INTO Product 
        (ProductID, ProductName, CategoryID, Price, Capacity)
        VALUES 
        (@ProductID, @ProductName,  @CategoryID, @Price, @Capacity)";

        public const string GetAvailableLocations = @"
        SELECT LocationID 
        FROM Location 
        WHERE Availability = 'Available'
        ORDER BY 
            LEFT(LocationID, 1),
            TRY_CAST(PARSENAME(REPLACE(LocationID, '-', '.'), 3) AS INT),
            TRY_CAST(PARSENAME(REPLACE(LocationID, '-', '.'), 2) AS INT),
            TRY_CAST(PARSENAME(REPLACE(LocationID, '-', '.'), 1) AS INT)";

        public const string UpdateLocation = @"
        UPDATE Location
        SET ProductID = @ProductID,
            Availability = 'Occupied',
            Capacity = @Capacity
        WHERE LocationID = @LocationID";


    }

}
