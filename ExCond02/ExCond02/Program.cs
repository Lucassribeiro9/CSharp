using System;

namespace ExCond02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if (N % 2 == 0)
            {
                Console.WriteLine($"{N} é par!");
            }
            else
            {
                Console.WriteLine($"{N} é impar!");
            }
        }
    }
}
