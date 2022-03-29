using System;
using System.Collections.Generic;
using System.Linq;
using ExLINQ.Entities;

namespace ExLINQ
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "PC", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product(){Id = 1, Name = "PC", Price = 2000, Category = c2 },
                new Product(){Id = 2, Name = "Hammer", Price = 90, Category = c1 },
                new Product(){Id = 1, Name = "TV", Price = 575, Category = c3 },
                new Product(){Id = 1, Name = "Notebook", Price = 4999, Category = c2 }
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            Print($"Tier 1 and Price under $900: ", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("Names of products from tools: ", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("Names started with 'C' and anonymous object: ", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Tier 1 order by price and name: ", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("Tier 1 order by price and name (skip & take): ", r5);

            var r6 = products.First();
            Console.WriteLine("First test 1: " + r6);

            var r7 = products.Where(p => p.Price > 3000).FirstOrDefault();
            Console.WriteLine("First test 2: " + r7);

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default: " + r8);

            var r9 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r9);

            var r10 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r10);

            var r11 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r11);

            var r12 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + r12);

            var r13 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Average prices: " + r13);

            var r14 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + r14);

            var r15 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> group in r15)
            {
                Console.WriteLine($"Category: {group.Key.Name}");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
