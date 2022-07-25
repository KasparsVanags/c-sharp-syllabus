using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            const int lowerBound = 1;
            const double upperBound = 100;
            const double average = (lowerBound + upperBound) / 2;

            for (var number = lowerBound; number <= upperBound; ++number) 
            {
                sum += number;
            }
            Console.WriteLine($"The sum of {lowerBound} and {upperBound} is {sum}");
            Console.WriteLine($"The average is {average}");
        }
    }
}
