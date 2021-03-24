using System;
using System.Globalization;

namespace VetorExemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // VETORES COM REFERENCIA DE CLASSE
            
            int n = int.Parse(Console.ReadLine());

            Product[] produtos = new Product[n];

            for (int i = 0; i<n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produtos[i] = new Product { Nome = name, Preco = price }; 

            }

            double soma = 0;
            for (int i = 0; i<n; i++)
            {
                soma += produtos[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine($"Preço médio: {media}");
        }
    }
}
