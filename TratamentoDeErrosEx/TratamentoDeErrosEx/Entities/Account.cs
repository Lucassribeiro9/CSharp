using System;
using TratamentoDeErrosEx.Entities.Exceptions;

namespace TratamentoDeErrosEx.Entities
{
    class Account
    {
        public int Number { get; }
        public string Holder { get; private set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if (number <= 0)
            {
                throw new DomainException("Invalid number account");
            }
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (Balance <= 0)
            {
                throw new DomainException("Insufficient funds!");
            }
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");

            }
            Balance -= amount;
        }
        
    }
}
