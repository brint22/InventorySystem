﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class ProductStock
    {
        public int StockID { get; set; }
        public string ProductID { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Supplier { get; set; }
        public DateTime ProductRecieved { get; set; }
        public string Capacity { get; set; }
        public string ProductName { get; set; }
        public int Count { get; set; }
    }
}
