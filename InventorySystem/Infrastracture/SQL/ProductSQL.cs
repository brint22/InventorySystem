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
        SELECT [LocationID],
               ProductID,
               Availability,
               Capacity
        FROM [WAREHOUSEISDB].[dbo].[Location]
        ORDER BY 
            LEFT(LocationID, CHARINDEX('-', LocationID) - 1), -- first part: the letter (A, B, etc.)
            CAST(SUBSTRING(LocationID, CHARINDEX('-', LocationID) + 1, CHARINDEX('-', LocationID, CHARINDEX('-', LocationID) + 1) - CHARINDEX('-', LocationID) - 1) AS INT), -- second part: the first number
            CAST(SUBSTRING(LocationID, CHARINDEX('-', LocationID, CHARINDEX('-', LocationID) + 1) + 1, LEN(LocationID)) AS INT) -- third part: the second number
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

    }

}
