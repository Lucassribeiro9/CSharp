using System;

namespace NewVectEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Students[] vect = new Students[10]; // o tamanho do vetor é determinado no começo do enunciado

            Console.WriteLine("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Aluguel #{i}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Students(nome, email); // vetor vai receber os dados preenchidos do quarto

            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                // mostrará apenas as posições que foram escolhidas
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]); 
                }
            }
        }
    }
}
