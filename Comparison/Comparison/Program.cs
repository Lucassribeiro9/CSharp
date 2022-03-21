using Comparison.Entities;
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
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            list.Sort(comp);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        // só pra commitar
        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
