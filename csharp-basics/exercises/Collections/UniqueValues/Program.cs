using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var values = new List<string> { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };
            Console.WriteLine("Input: " + string.Join(", ", values));
            var result = values.Distinct();
            Console.WriteLine("Unique: " + string.Join(", ", result));
            Console.ReadKey();
        }
    }
}
