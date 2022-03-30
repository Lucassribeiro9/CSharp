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

            // var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            var r1 = from p in products
                     where p.Category.Tier == 1 && p.Price < 900
                     select p;
            Print($"Tier 1 and Price under $900: ", r1);

            // var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var r2 = from p in products where p.Category.Name == "Tools" select p.Name;
            Print("Names of products from tools: ", r2);

            // var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 = from p in products where p.Name[0] == 'C' select new { p.Name, p.Price, CategoryName = p.Category.Name };
            Print("Names started with 'C' and anonymous object: ", r3);

            // var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 = from p in products where p.Category.Tier == 1 orderby p.Name orderby p.Price select p;
            Print("Tier 1 order by price and name: ", r4);

            // var r5 = r4.Skip(2).Take(4);
            var r5 = (from p in r4 select p).Skip(2).Take(4); // operação entre parenteses e depois junta com a operação que precisar
            Print("Tier 1 order by price and name (skip & take): ", r5);

            var r6 = from p in products group p by p.Category;
            foreach (IGrouping<Category, Product> group in r6)
            {
                Console.WriteLine($"Category {group.Key.Name}: ");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

        }
    }
}
