using System;

namespace CozaLozaWoza
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (var i = 1; i <= 110; i++)
            {
                var word = false;
                if (i % 3 == 0)
                {
                    Console.Write("Coza");
                    word = true;
                }
                if (i % 5 == 0)
                {
                    Console.Write("Loza");
                    word = true;
                }
                if (i % 7 == 0)
                {
                    Console.Write("Woza");
                    word = true;
                }

                if (!word)
                {
                    Console.Write(i);
                }
                
                Console.Write(" ");
                
                if (i % 11 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}