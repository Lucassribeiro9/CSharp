using System;

namespace ExEntSaiDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int quarto = int.Parse(Console.ReadLine());
            double preco = double.Parse(Console.ReadLine());

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int quarto = int.Parse(vet[1]);
            double preco = double.Parse(vet[2]);

            Console.WriteLine("Entre com seu nome: ");
            Console.WriteLine(nome);
            Console.WriteLine("Quantos quartos tem sua casa?");
            Console.WriteLine(quarto);
            Console.WriteLine("O preço de um produto: ");
            Console.WriteLine(preco);


        }
    }
}
