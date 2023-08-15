﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterProductInventory
{
    public class MyProduct : BaseEntity
    {
        public MyProduct(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public override bool Validate()
        {
            var isValid = true;
            if (String.IsNullOrWhiteSpace(Name)) isValid = false;
            return isValid;
        }
    }
}
