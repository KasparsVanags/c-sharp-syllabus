using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "";
            Console.WriteLine("Input a .txt file path or press Enter to use the included lear.txt");
            var input = Console.ReadLine();
            if (input == "")
            {
                text = File.ReadAllText(Directory.GetCurrentDirectory() + @"\lear.txt");
                Console.WriteLine("Using default lear.txt");
            }
            else
            {
                text = File.ReadAllText(input);
                Console.WriteLine("Using: " + input);
            }

            Console.WriteLine("Lines = " + (text.Count(x => x == '\n') + 1));
            Console.WriteLine("Words = " + Regex.Matches(text, @"\w+").Count);
            Console.WriteLine("Chars = " + text.Count(x => !char.IsControl(x)));
            Console.ReadKey();
        }
    }
}
