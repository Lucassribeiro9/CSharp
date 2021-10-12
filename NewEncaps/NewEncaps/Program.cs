using System;

namespace NewEncaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Props name = new Props();
            Console.WriteLine("Digite um nome: ");
            name.Nome = Console.ReadLine();
            Console.WriteLine(name.Nome);
            Console.WriteLine("Quantidade de pião com esse nome: ");
            name.Quantidade = int.Parse(Console.ReadLine());
        }
    }
}
