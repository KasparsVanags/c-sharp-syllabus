using System;
using System.Collections.Generic;

namespace ListExercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine("First list:");
            Console.WriteLine(string.Join(",", firstList));

            var secondList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };
            
            Console.WriteLine("Second list:");
            Console.WriteLine(string.Join(",", secondList));
            firstList.AddRange(secondList);
            Console.WriteLine("First list and second list together:");
            Console.WriteLine(string.Join(",", firstList));
            Console.ReadKey();
        }
    }
}
