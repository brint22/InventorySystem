using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationStart { get; set; }
        public string LocationFinish { get; set; }
        public string Availability { get; set; }

        
    }
}
