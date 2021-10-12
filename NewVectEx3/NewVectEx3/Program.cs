using System;

namespace NewVectEx3
{
    class Program
    {

        static void Main(string[] args)
        {




            Runners[] vect = new Runners[4];

            Console.Write("Quantidade de corredores: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Corredor #{i}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("País: ");
                string pais = Console.ReadLine();
                Console.Write("Posição no grid: ");
                int position = int.Parse(Console.ReadLine());
                vect[position] = new Runners(nome, pais);
            }
            Console.WriteLine();
            Console.WriteLine("Participantes:");
            for (int i = 0; i < 4; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine($"{i}: {vect[i]}");
                }
            }

            foreach (Runners obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
