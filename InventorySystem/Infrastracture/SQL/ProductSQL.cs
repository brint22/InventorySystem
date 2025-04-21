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
    }
}
