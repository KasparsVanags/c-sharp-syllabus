using System;

namespace Product1ToN
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const int fromNumber = 1;
            const int toNumber = 10;
            int result = 1;
            
            for (var i = fromNumber; i <= toNumber; i++)
            {
                result *= i;
            }
            
            Console.WriteLine($"The product of {toNumber} is {result}");
        }
    }
}