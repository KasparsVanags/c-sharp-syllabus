using System;

namespace Exercise11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.WriteLine("Enter a string in which to to reverse the case");
                var input = Console.ReadLine();
                foreach (var letter in input)
                {
                    if (char.IsUpper(letter))
                    {
                        Console.Write(char.ToLower(letter));
                    }
                    else if (char.IsLower(letter))
                    {
                        Console.Write(char.ToUpper(letter));
                    }
                    else
                    {
                        Console.Write(letter);
                    }
                }
                
                Console.WriteLine();
            }
        }
    }
}