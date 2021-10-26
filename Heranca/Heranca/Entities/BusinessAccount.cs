using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    class BusinessAccount : Account // herança. Terá tudo que a classe base tem
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(double loanLimit)
        {
            LoanLimit = loanLimit;
        }
        // reuso no construtor
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
