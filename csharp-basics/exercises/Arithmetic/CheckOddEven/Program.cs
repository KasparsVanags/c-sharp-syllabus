using System;

namespace CheckOddEven
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const int number = 2;
            Console.WriteLine(number % 2 == 0 ? "Even Number" : "Odd Number");
            Console.WriteLine("bye!");
        }
    }
}