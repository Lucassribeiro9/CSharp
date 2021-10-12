using System;

namespace ExClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Idade x;
            x = new Idade();
           


            Console.WriteLine("Digite os dados da primeira pessoa");
            Console.Write("Nome: ");
            string nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            x.A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite os dados da segunda pessoa");
            Console.Write("Nome: ");
            string nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            x.B = Convert.ToDouble(Console.ReadLine());

            if (x.A > x.B)
            {
                Console.WriteLine($"Pessoa mais velha: {nome1}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {nome2}");
            }
        }
    }
}
