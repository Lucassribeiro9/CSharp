using System;

namespace ExConstIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1;
            Pessoa p2;
            Pessoa p3;
            Console.Write($"Digite o nome da pessoa: ");
            p1 = new Pessoa();
            p1.Nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.Write($"Digite o nome da pessoa: ");
            p2 = new Pessoa();
            p2.Nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            p2.Idade = int.Parse(Console.ReadLine());
            Console.Write($"Digite o nome da pessoa: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());
            p3 = new Pessoa(nome, idade);

            if ((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p1.ExibirDados();
            }
            else if ((p2.Idade > p1.Idade) && (p2.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p2.ExibirDados();
            }
            else if ((p3.Idade > p1.Idade) && (p3.Idade > p2.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p3.ExibirDados();
            }
            else
            {
                Console.WriteLine("As idades são iguais!");

            }
        }
    }
}
