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
        public int Availability { get; set; }

        // Computed property for Availability
        public string AvailabilityText
        {
            get
            {
                return Availability == 1 ? "Available" :
                       Availability == 0 ? "Not Available" :
                       "Unknown";
            }
        }

    }
}
