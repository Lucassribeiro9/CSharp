﻿using System;
using System.Collections.Generic;
using DemoLinqSql.Entities;
using System.IO;
using System.Globalization;
using System.Linq;

namespace DemoLinqSql
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Product(price, name));
                }
            }
            var avg = list.Select(p => p.Price).DefaultIfEmpty(0).Average();
            Console.WriteLine($"Average price: {avg.ToString("F2", CultureInfo.InvariantCulture)}");

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
