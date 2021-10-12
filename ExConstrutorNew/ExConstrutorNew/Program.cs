using System;
using System.Globalization;

namespace ExConstrutorNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta contaBancaria;

            Console.Write("Entre com o número da conta: ");
            int numCon = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new Conta(numCon, nome, depInicial);
            }
            else
            {
                contaBancaria = new Conta(numCon, nome);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);
            Console.WriteLine();
            Console.Write("Entre com um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposito(deposito);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);
            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Saque(saque);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);

        }
    }
}
