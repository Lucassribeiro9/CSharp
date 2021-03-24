using System;
using System.Globalization;

namespace ContaBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 'S' || resp == 's')
            {
                Console.WriteLine("Entre com o valor do depósito: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta1 = new Conta(titular, numero, depositoInicial);
            }
            else
            {
                conta1 = new Conta(titular, numero );
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta1);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta1);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta1);
        }
    }
}
