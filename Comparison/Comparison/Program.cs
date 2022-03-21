﻿using Comparison.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            int n = 3;
            
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Product name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }
            list.Sort(CompareProducts);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
