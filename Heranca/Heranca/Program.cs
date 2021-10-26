using System;
using Heranca.Entities;
namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob", 100, 500);
            Console.WriteLine(account.Balance);
        }
    }
}
