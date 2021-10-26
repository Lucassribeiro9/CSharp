using System;
using UpAndDowncasting.Entities;

namespace UpAndDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500);

            // UPCASTING
            // variavel recebe qualquer tipo de subclasse pertencente a ela
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount();
            Account acc3 = new SavingsAccount();

            // DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2; // converter em downcasting
            acc4.Loan(100); // os métodos só valem se o objeto for do tipo da classe

          //  BusinessAccount acc5 = (BusinessAccount)acc3; // embora não tenha apontado erro no compilador, não é possível a conversão
            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc6 = (BusinessAccount)acc3;
                acc6.Loan(200);
                Console.WriteLine("Loan");

            }
            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc7 = (SavingsAccount)acc3;
                acc7.UpdateBalance();
                Console.WriteLine("Update Balance");
            }
        }
    }
}
