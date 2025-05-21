using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class Sale
    {
        public int SaleID { get; set; }
        public decimal QuantitySold { get; set; }
        public string ProductID { get; set; }
        public int OrderID { get; set; }


    }
}
