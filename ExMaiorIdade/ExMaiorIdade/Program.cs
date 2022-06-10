using System;
using System.Collections.Generic;
using System.Linq;

namespace ExMaiorIdade
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
            Console.WriteLine("Quantas pessoas deseja cadastrar: ");
            int n = int.Parse(Console.ReadLine());
            List<Pessoa> list = new List<Pessoa>();
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                list.Add(new Pessoa(idade, nome));

            }
            foreach (Pessoa obj in list)
            {
                Console.WriteLine(obj);
            }
            
            // to batendo cabeça pra trazer uma lista de idade por ordem crescente acima
        }
    }
}
