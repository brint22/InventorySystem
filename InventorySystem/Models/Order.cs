using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class Order
    {
        public string OrderID { get; set; }
        public string TotalPrice { get; set; }
        public string PaymentAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public int Count { get; set; }
    }
}
