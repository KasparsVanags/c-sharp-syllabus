using System;
using System.Collections.Generic;

namespace Exercise10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var stringHashSet = new HashSet<string>();
            stringHashSet.Add("i'm");
            stringHashSet.Add("not");
            stringHashSet.Add("very");
            stringHashSet.Add("creative");
            stringHashSet.Add(".com");
            Console.WriteLine("Listing all 5 values:");
            foreach (var entry in stringHashSet)
            {
                Console.WriteLine(entry);
            }
            
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.WriteLine();
            stringHashSet.Clear();
            Console.WriteLine("Removed everything, now contains:");
            foreach (var entry in stringHashSet)
            {
                Console.WriteLine(entry);
            }
            
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(new string('!', 82));
            Console.WriteLine("!WARNING! We'll attempt to add duplicate values, put on your safety gear !WARNING!");
            Console.WriteLine(new string('!', 82));
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Are you sure? Y/N:");
            var input = "";
            while (input != "y" && input != "n")
            {
                input = Console.ReadLine().ToLower();
            }

            if (input == "n")
            {
                Environment.Exit(0);
            }

            Console.WriteLine("Adding the same value 5 times...");
            stringHashSet.Add("same");
            stringHashSet.Add("same");
            stringHashSet.Add("same");
            stringHashSet.Add("same");
            stringHashSet.Add("same");
            Console.WriteLine("The HashSet now contains:");
            foreach (var entry in stringHashSet)
            {
                Console.WriteLine(entry);
            }

            Console.ReadKey();
        }
    }
}