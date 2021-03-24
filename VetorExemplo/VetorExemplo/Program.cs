using System;
using System.Globalization;

namespace VetorExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a quantidade de pessoas: ");
                int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n]; // instanciando o vetor: new tipovetor[numero de elementos]
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite sua altura: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
            }
            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i];
            }

            double media = soma / n;

            Console.WriteLine(media);
        }
    }
}
