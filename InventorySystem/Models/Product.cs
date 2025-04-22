using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public DateTime ProductRecieved { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string BrandName { get; set; }
        public string Supplier { get; set; }
        public int CategoryID { get; set; }
        public int LocationID { get; set; }

        public string CategoryName { get; set; }
        public string LocationStart { get; set; }
        public string LocationFinish { get; set; }
        public string Availability { get; set; }
    }
}
