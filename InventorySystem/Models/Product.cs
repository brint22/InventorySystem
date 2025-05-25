﻿using System;
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
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int Capacity { get; set; }
    }
}
