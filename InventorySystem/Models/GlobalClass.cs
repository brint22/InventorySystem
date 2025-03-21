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
        //    Initial Catalog=WAREHOUSEISDB; 
        //    Trusted_Connection=True;";

        @"Data Source=NIEZEL\SQLEXPRESS; 
        Initial Catalog=WAREHOUSEISDB; 
        Trusted_Connection=True;";

        //public static int testmethod(int param1, int param2)
        //{
        //    int result = 0;
        //    result = param1 + param2;
        //    return result;
        //}
    }
}
