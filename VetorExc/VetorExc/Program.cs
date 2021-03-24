using System;

namespace VetorExc
{
    class Program
    {
        static void Main(string[] args)
        {
            Students[] vetor = new Students[10]; 
            
            Console.Write("Quantos quartos serão alugados?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine();
                Console.Write($"Aluguel {i}: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Students(nome, email);

            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i <= 10; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine($"{i}: {vetor[i]}");
                }
            }
            
        }
    }
}
