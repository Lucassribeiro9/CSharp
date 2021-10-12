using System;
using System.Globalization;

namespace ExPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Ano de nascimento: ");
            p.DataNasc = DateTime.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            p.Altura = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados da pessoa: ");
            Console.WriteLine($"Nome: {p.Nome}");
            Console.WriteLine($"Idade: {p.CalcularIdade()}");
            Console.WriteLine($"Altura: {p.Altura.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
