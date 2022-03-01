using System;

namespace ExempGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> printService = new PrintService<string>(); // na hora de instanciar nós definimos o tipo
            Console.Write("How many values: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string x = Console.ReadLine();
                printService.AddValue(x);
            }
            printService.Print();
            Console.WriteLine();
            Console.WriteLine($"First: {printService.First()}");
        }
    }
}
