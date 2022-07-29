using System;

namespace FizzBuzz
{
    internal class FizzBuzz
    {
        public static void Main(string[] args)
        {
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.Write("Max value? ");
                int maxValue = int.Parse(Console.ReadLine());
                for (var i = 1; i <= maxValue; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.Write("FizzBuzz ");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.Write("Fizz ");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write("Buzz ");
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }

                    if (i % 20 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}