using System;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var watingForInput = true;
            while (watingForInput)
            {
                Console.Write("Enter the number: ");
                var input = int.Parse(Console.ReadLine());
                if (input > 0)
                {
                    Console.WriteLine("Number is positive");
                }
                else if (input < 0)
                {
                    Console.WriteLine("Number is negative");
                }
                else
                {
                    Console.WriteLine("Number is zero");
                }
            }
        }
    }
}
