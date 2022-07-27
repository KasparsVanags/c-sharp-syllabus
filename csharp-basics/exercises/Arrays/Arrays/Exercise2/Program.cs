using System;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());
            int[] minToMaxArr = Enumerable.Range(minNumber, maxNumber - minNumber + 1).ToArray();
            
            Console.WriteLine("The sum is " + minToMaxArr.Sum());
            Console.ReadKey();
        }
    }
}
