using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLinqSql.Entities
{
    class Product
    {
        
        public double Price { get; set; }
        public string Name { get; set; }

        public Product(double price, string name)
        {
            Price = price;
            Name = name;
        }
    }
}
