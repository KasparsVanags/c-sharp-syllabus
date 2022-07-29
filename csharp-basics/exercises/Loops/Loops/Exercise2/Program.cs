using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.WriteLine("Input number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many times to multiply: ");
                var times = Convert.ToInt32(Console.ReadLine());
                var result = number;
                for (var j = 1; j < times; j++)
                {
                    result *= number;
                }
                
                Console.WriteLine($"{number} to the power of {times} equals {result}");
            }
        }
    }
}
