using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class Location
    {
        public string LocationID { get; set; }
        public string ProductID { get; set; }     
        public string Availability { get; set; }
        public string Capacity { get; set; }


    }
}
