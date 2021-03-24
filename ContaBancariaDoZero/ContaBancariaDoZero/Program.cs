using System;

namespace ContaBancariaDoZero
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o nome do titular: ");
            string nome = Console.ReadLine();
            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Haverá depósito inicial (s/n)?: ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Digite o valor do depósito: ");
                double deposito = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(nome, numeroConta, deposito);
            }
            else
            {
                conta = new ContaBancaria(nome, numeroConta);
            }
            Console.WriteLine();
            Console.Write($"Dados da conta: {conta}");
            
            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine());
            conta.Deposito(valor);
            Console.WriteLine();
            Console.Write($"Dados atualizados: {conta}");

            Console.WriteLine();
            Console.Write("Digite um valor para sacar: ");
            valor = double.Parse(Console.ReadLine());
            conta.Saque(valor);
            Console.WriteLine();
            Console.Write($"Dados atualizados: {conta}");


        }
    }
}
