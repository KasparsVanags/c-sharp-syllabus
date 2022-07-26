using System;

namespace Exercise1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool TrueOrFalse(int int1, int int2)
            {
                return int1 == 15 ||
                       int2 == 15 ||
                       int1 + int2 == 15 ||
                       Math.Abs(int1 - int2) == 15;
            }

            Console.ReadKey();
        }
    }
}