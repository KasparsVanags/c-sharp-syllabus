using System;

namespace Exercise7
{
    public class SavingsAccount
    {
        private decimal _balance;
        private decimal _annualInterest;
        public SavingsAccount(decimal startingBalance)
        {
            _balance = startingBalance;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= _balance)
            {
                _balance -= amount;
                return true;
            }

            Console.WriteLine("Insufficient funds");
            return false;
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        private decimal GetMonthlyInterest()
        {
            return _annualInterest / 12;
        }

        public void SetInterest(decimal annualInterest)
        {
            _annualInterest = annualInterest;
        }

        public decimal AddMonthlyInterest()
        {
            var interest = GetMonthlyInterest() * _balance;
            _balance += interest;
            return interest;
        }
    }
}