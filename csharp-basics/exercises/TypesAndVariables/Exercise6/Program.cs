using System;

namespace Exercise6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter single digit numbers to sum\nPress R to reset or Q to quit");
            int sum = 0;
            var initialized = false;
            var waitingForInput = true;
            while (waitingForInput)
            {
                var input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case 'r':
                        sum = 0;
                        break;
                    case 'q':
                        Environment.Exit(0);
                        break;
                    default:
                        sum += int.Parse(input.ToString());
                        break;
                }

                if (initialized)
                {
                    Console.Write($" = {sum}\n{sum} + ");
                }
                else
                {
                    Console.Write(" + ");
                    initialized = true;
                }
            }
        }
    }
}