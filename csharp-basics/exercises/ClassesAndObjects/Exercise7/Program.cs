using System;
using System.Globalization;

namespace Exercise7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            decimal totalDeposit = 0;
            decimal totalWithdrawn = 0;
            decimal interestEarned = 0;
            var usdFormat = new CultureInfo("en-US");
            Console.Write("How much money is in the account?: ");
            var savings = new SavingsAccount(decimal.Parse(Console.ReadLine()));
            Console.Write("Enter the annual interest rate: ");
            savings.SetInterest(decimal.Parse(Console.ReadLine()));
            Console.Write("How long has the account been opened for?: ");
            var duration = int.Parse(Console.ReadLine());
            for (var i = 1; i <= duration; i++)
            {
                bool insufficientFunds;
                Console.Write($"Enter the amount deposited for month {i}: ");
                var deposit = decimal.Parse(Console.ReadLine());
                savings.Deposit(deposit);
                totalDeposit += deposit;
                do
                { 
                    insufficientFunds = false;
                    Console.Write($"Enter the amount withdrawn for month {i}: ");
                    var withdraw = decimal.Parse(Console.ReadLine());
                    if (savings.Withdraw(withdraw))
                    {
                        totalWithdrawn += withdraw;
                    }
                    else
                    {
                        insufficientFunds = true;
                    }
                } while (insufficientFunds);

                interestEarned += savings.AddMonthlyInterest();
            }
            
            Console.WriteLine($"Total deposited: {FormatCurrency(totalDeposit)}");
            Console.WriteLine($"Total withdrawn: {FormatCurrency(totalWithdrawn)}");
            Console.WriteLine($"Interest earned: {FormatCurrency(interestEarned)}");
            Console.WriteLine($"Ending balance: {FormatCurrency(savings.GetBalance())}");
            Console.ReadKey();
            
            string FormatCurrency(decimal currency)
            {
                return currency.ToString("C", usdFormat);
            }
        }
    }
}