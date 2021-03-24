using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            // list <tipo do elemento> = instanciado
            List<string> list1 = new List<string>();
            list1.Add("Maria"); // espera que você adicione um elemento do tipo da sua lista
            list1.Add("Bob");
            list1.Add("Alex");
            list1.Add("Ana");
            list1.Insert(2, "Marco"); // Insere um dado em determinada posição da lista
            foreach (string nome in list1)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("List count: " + list1.Count); // conta os elementos da lista

            string s1 = list1.Find(x => x[0] == 'A'); // predicado é uma função que pega um valor por trás da lógica booleana; predicado atual é uma expressão lambda
            Console.WriteLine($"First 'A': {s1}");

            string s2 = list1.FindLast(x => x[0] == 'A'); // predicado é uma função que pega um valor por trás da lógica booleana; predicado atual é uma expressão lambda
            Console.WriteLine($"Last 'A': {s2}");

            int pos1 = list1.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"First position 'A': {pos1}");

            int pos2 = list1.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"Last position 'A': {pos2}");

            List<string> list2 = list1.FindAll(x => x.Length == 5);
            Console.WriteLine("---------");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list1.Remove("Alex");
            Console.WriteLine("---------------------");
            foreach (string obj in list1)
            {
                Console.WriteLine(obj);
            }
            list1.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------");
            foreach (string obj in list1)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
