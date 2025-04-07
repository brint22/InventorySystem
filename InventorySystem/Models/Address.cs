using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public string BarangayName { get; set; }
        public string MunicipalityName { get; set; }
        public string ProvinceName { get; set; }
        public int ZipCodeNumber { get; set; }
        public string CountryName { get; set; }
    }
}
