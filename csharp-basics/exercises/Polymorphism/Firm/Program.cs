using System;

namespace Firm
{
    class Program
    {
        private static void Main(string[] args)
        {
            var personnel = new Staff();
            personnel.Payday();
            Console.ReadKey();
        }
    }
}