using System;
using System.Globalization;

namespace NewVetorEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // comece com o input da quantidade de posições do vetor
            Console.Write("Quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o valor do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                // instanciei o produto, pois as posições do vetor recebem nulo quando se trata do tipo referência (classe)
                vect[i] = new Product(nome, preco);
            }
            // preço médio
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price; // peguei o objeto que deixa possível a realização do calculo
            }
            double avg = sum / n;

            Console.WriteLine($"Preço médio: {avg}");
        }
    }
}
