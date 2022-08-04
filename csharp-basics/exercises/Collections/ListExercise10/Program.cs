using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine("Original list: ");
            Console.WriteLine(string.Join(",", colors.Cast<string>().ToArray()));
            colors.Clear();
            Console.WriteLine("Everything removed: ");
            Console.WriteLine(string.Join(",", colors.Cast<string>().ToArray()));
            Console.ReadKey();
        }
    }
}
