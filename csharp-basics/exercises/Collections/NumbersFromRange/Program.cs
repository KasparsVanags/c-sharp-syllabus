using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersFromRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var numbers = new List<int>();
            
            while (numbers.Count() < 10)
            {
                numbers.Add(random.Next(1, 100));
            }
            
            Console.WriteLine("All numbers:");
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine("30 < x < 100:");
            var resultList = numbers.Where(num => num is > 30 and < 100).ToList();
            Console.WriteLine(string.Join(", ", resultList));
            Console.ReadKey();
        }
    }
}
