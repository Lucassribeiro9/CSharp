using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) // intuito de percorrer as linhas
            {
                string[] values = Console.ReadLine().Split(' '); // ele separa os dados por espaço e armazena no vetor
                
                for (int j = 0; j < n; j++) // percorrer as colunas e vai executar pra cada uma das linhas
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mat[i, i] + " ");
            }
            Console.WriteLine();


            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Negative number: {count}");

        }
    }
}
