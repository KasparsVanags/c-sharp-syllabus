using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The first 10 natural numbers are: ");
            for (var i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}