using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a name or press Enter to list unique names entered so far");
            var nameList = new List<string>();
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.Write("Enter a name or nothing and press enter: ");
                var input = Console.ReadLine();
                if (input == "")
                {
                    Console.WriteLine("Unique name list contains: " + string.Join(", ", nameList.Distinct()));
                }
                else
                {
                    nameList.Add(input);
                }
            }
        }
    }
}