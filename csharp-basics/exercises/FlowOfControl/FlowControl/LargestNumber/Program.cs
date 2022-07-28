using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.Write("Input the 1st number: ");
                var input1 = int.Parse(Console.ReadLine());
                Console.Write("Input the 2nd number: ");
                var input2 = int.Parse(Console.ReadLine());
                Console.Write("Input the 3rd number: ");
                var input3 = int.Parse(Console.ReadLine());
                var biggestNumber = Math.Max(input1, Math.Max(input2, input3));
                Console.WriteLine("Max value: " + biggestNumber);
            }
        }
    }
}
