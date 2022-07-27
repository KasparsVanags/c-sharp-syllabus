using System;

namespace CheckOddEven
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const int numberToCheck = 2;
            Console.WriteLine(numberToCheck % 2 == 0 ? "Even Number" : "Odd Number");
            Console.WriteLine("bye!");
            Console.ReadKey();
        }
    }
}