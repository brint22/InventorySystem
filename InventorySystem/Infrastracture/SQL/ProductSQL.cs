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
              Availability
              FROM [WAREHOUSEISDB].[dbo].[Location]
              ORDER BY 
              CAST(SUBSTRING([LocationID], CHARINDEX('-', [LocationID], 1) + 1, CHARINDEX('-', [LocationID], CHARINDEX('-', [LocationID]) + 1) - CHARINDEX('-', [LocationID]) - 1) AS INT) ASC,
              CAST(SUBSTRING([LocationID], CHARINDEX('-', [LocationID], CHARINDEX('-', [LocationID]) + 1) + 1, LEN([LocationID])) AS INT) ASC";

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
    }

}
