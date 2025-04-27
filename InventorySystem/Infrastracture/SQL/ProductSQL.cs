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
        SELECT LocationID, ProductID, Availability 
        FROM Location";

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
