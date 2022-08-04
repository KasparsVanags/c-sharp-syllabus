using System;
using System.Collections.Generic;

namespace ListExercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };
            
            Console.WriteLine(string.Join(",", colors));
            Console.WriteLine("After removing third element from the list:");
            colors.RemoveAt(2);
            Console.WriteLine(string.Join(",", colors));
            Console.ReadKey();
        }
    }
}
