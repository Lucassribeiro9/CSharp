using ConstrutorThis;
using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Properties p = new Properties("TV", 500.00, 1);

            p.Nome = "RADIO";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);

        }
    }
}