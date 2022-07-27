using System;
using System.Linq;

namespace Exercise7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type something, press enter and i will tell you how many uppercase letters there are");
            var waitingForInput = true;
            while (waitingForInput)
            {
                string input = Console.ReadLine();
                Console.WriteLine("There are " + input.Where(char.IsUpper).Count() + " uppercase letters");
            }
        }
    }
}