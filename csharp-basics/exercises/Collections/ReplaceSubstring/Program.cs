using System;
using System.Linq;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" }; 
            Console.WriteLine("Input: " + string.Join(", ", words));
            var resultWords = words.Select(word => word.Replace("ea", "*"));
            Console.WriteLine("Result: " + string.Join(", ", resultWords));
            Console.ReadKey();
        }
    }
}
