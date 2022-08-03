using System;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var bartosAccount = new Account("Barto's account",100.00);
            var bartosSwissAccount = new Account("Barto's account in Switzerland",1000000.00);
            Console.WriteLine("Initial state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);
            Console.WriteLine("Deposit 20 to Barto's account");
            bartosAccount.Withdrawal(20);
            Console.WriteLine("Barto's account balance is now: "+bartosAccount.Balance());
            Console.WriteLine("Deposit 200 to Barto's account in Switzerland");
            bartosSwissAccount.Deposit(200);
            Console.WriteLine("Barto's Swiss account balance is now: "+bartosSwissAccount.Balance());
            Console.WriteLine("Final state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);
            PrintLine();
            
            var mattsAccount = new Account("Matt's account", 1000);
            var myAccount = new Account("My account", 0);
            Console.WriteLine("Initial state");
            Console.WriteLine(mattsAccount + "\n" + myAccount);
            Console.WriteLine("Withdraw 100 from Matt's account and deposit 100 to My account");
            mattsAccount.Withdrawal(100);
            myAccount.Deposit(100);
            Console.WriteLine(mattsAccount + "\n" + myAccount);
            PrintLine();
            
            var a = new Account("A", 100);
            var b = new Account("B", 0);
            var c = new Account("C", 0);
            Console.WriteLine("Initial state");
            AbcState();
            Console.WriteLine("Transfer 50 from A to B");
            Transfer(a, b, 50);
            AbcState();
            Console.WriteLine("Transfer 25 from B to C");
            Transfer(b, c, 25);
            Console.WriteLine($"{a}\n{b}\n{c}");
            Console.ReadKey();
            
            void AbcState()
            {
                Console.WriteLine($"{a}\n{b}\n{c}");
            }
        }

        static void Transfer(Account from, Account to, double howMuch)
        {
            from.Withdrawal(howMuch);
            to.Deposit(howMuch);
        }

        static void PrintLine()
        {
            Console.WriteLine(new string('=', 70));
        }
    }
}
