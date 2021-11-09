using System;
using System.Globalization;
using TratamentoDeErrosEx.Entities;
using TratamentoDeErrosEx.Entities.Exceptions;

namespace TratamentoDeErrosEx
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.WriteLine();
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdraw_limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, balance, withdraw_limit);
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                acc.Withdraw(amount);
                Console.WriteLine($"New balance: {acc.Balance}");

            }
            catch (DomainException err)
            {
                Console.WriteLine(err.Message); ;
            }
            catch (FormatException err)
            {
                Console.WriteLine($"Format error: {err.Message}");
            }
            catch (Exception err)
            {
                Console.WriteLine($"Erro inesperado: {err.Message}");
            }
        }
    }
}
