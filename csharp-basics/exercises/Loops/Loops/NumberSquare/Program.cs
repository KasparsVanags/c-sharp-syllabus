using System;

namespace NumberSquare
{
    internal class NumberSquare
    {
        public static void Main(string[] args)
        {
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.WriteLine("Min?");
                var min = int.Parse(Console.ReadLine());
                Console.WriteLine("Max");
                var max = int.Parse(Console.ReadLine());
                for (var i = min; i <= max; i++)
                {
                    for (var j = i; j <= max; j++)
                    {
                        Console.Write(j);
                    }

                    for (var j = min; j < i; j++)
                    {
                        Console.Write(j);
                    }
                    
                    Console.WriteLine();
                }
            }
        }
    }
}