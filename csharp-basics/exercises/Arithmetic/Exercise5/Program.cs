using System;

namespace Exercise5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var rnd = new Random();
            var randomNum = rnd.Next(100);
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            if (int.TryParse(Console.ReadLine(), out var guess))
            {
                if (guess == randomNum)
                {
                    Console.WriteLine("You guessed it!  What are the odds?!?");
                }
                else
                {
                    Console.WriteLine(guess > randomNum ? $"Sorry, you are too high.  I was thinking of {randomNum}." : 
                        $"Sorry, you are too low.  I was thinking of {randomNum}.");
                }
            }
            else
            {
                Console.WriteLine("You must input a number!");
            }
            
        }
    }
}