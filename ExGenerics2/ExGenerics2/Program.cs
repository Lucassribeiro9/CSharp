using ExGenerics2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExGenerics2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                products.Add(new Product(name, price));
            }
            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(products);
            Console.WriteLine("Max: ");
            Console.WriteLine(max);
        }
    }
}
