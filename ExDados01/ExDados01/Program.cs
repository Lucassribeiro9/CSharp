using System;
using System.Globalization;

namespace ExEntSaiDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string NomeCompleto = Console.ReadLine(); // na entrada de dados, coloque o readline após o writeline, junto com a váriavel
            Console.WriteLine("Quantos quartos sua casa possui? ");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço do produto que deseja: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu último nome, idade e altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string UltimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(NomeCompleto);
            Console.WriteLine(quarto);
            Console.WriteLine(preco);
            Console.WriteLine(UltimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);



        }
    }
}
