using System;
using System.Collections.Generic;

namespace ExHashAndSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");
            Console.WriteLine(set.Contains("Notebook"));

            foreach (string obj in set) // mostrar os itens do set
            {
                Console.WriteLine(obj);
            }
        }
    }
}
