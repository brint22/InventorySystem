using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class GlobalClass
    {
        public static string connectionString =
        //@"Data Source=REDJYLL; 
        //Initial Catalog=WAREHOUSEISDB; 
        //Trusted_Connection=True;";

        @"Data Source=NIEZEL\SQLEXPRESS; 
        Initial Catalog=WAREHOUSEISDB; 
        Trusted_Connection=True;";

        //@"Data Source=LAB1-PC08; 
        //Initial Catalog = WAREHOUSEISDB; 
        //User ID = sa; Password = 123456;";
        
        //@"Data Source=LAB1-PC09; 
        //Initial Catalog = WAREHOUSEISDB; 
        //User ID = sa; Password = 123456;";
    }
}
