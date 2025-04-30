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
            [LocationID],
            ProductID,
            Availability,
            CAST(Capacity AS VARCHAR(10)) + '/100' AS Capacity,
            CASE 
                WHEN Capacity IS NULL THEN 'N/A'
                WHEN (100 - Capacity) = 0 THEN 'None'
                ELSE CAST((100 - Capacity) AS VARCHAR)
            END AS AvailableCapacity
        FROM [WAREHOUSEISDB].[dbo].[Location]
        ORDER BY 
            LEFT(LocationID, CHARINDEX('-', LocationID) - 1),
            CAST(SUBSTRING(LocationID, CHARINDEX('-', LocationID) + 1, CHARINDEX('-', LocationID, CHARINDEX('-', LocationID) + 1) - CHARINDEX('-', LocationID) - 1) AS INT),
            CAST(SUBSTRING(LocationID, CHARINDEX('-', LocationID, CHARINDEX('-', LocationID) + 1) + 1, LEN(LocationID)) AS INT)
        ";

        public static string InsertLocation = @"
        INSERT INTO Location (LocationID, ProductID, Availability) 
        VALUES (@LocationID, '', 'Available')";

        public const string GetLocationsByAvailability = @"
        SELECT 
            l.LocationID, 
            l.ProductID, 
            l.Availability
        FROM Location l     
        WHERE l.Availability = @Availability;";

        public const string GetLocationsByGroup = @"
        SELECT 
            l.LocationID, 
            l.ProductID, 
            l.Availability
        FROM Location l     
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
        (ProductID, ProductName, Price, Quantity, ProductRecieved, ExpirationDate, CategoryID, BrandName, Supplier)
        VALUES 
        (@ProductID, @ProductName, @Price, @Quantity, @ProductRecieved, @ExpirationDate, @CategoryID, @BrandName, @Supplier)";

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
