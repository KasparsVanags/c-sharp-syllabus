using System;

namespace Exercise3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var randomNum = new Random();
            var numberArray = new int[20];
            var waitingForInput = true;
            while (waitingForInput)
            {
                for (var i = 0; i < numberArray.Length; i++)
                {
                    numberArray[i] = randomNum.Next(50);
                }
                
                Console.WriteLine("Enter a number (1 - 50) and i'll tell you where it is (if it exists):");
                var userGuess = int.Parse(Console.ReadLine());
                var guessedNumberLocation = Array.IndexOf(numberArray, userGuess);
                if (guessedNumberLocation != -1)
                {
                    Console.WriteLine("The number you guessed is located at index " + guessedNumberLocation);
                }
                else
                {
                    Console.WriteLine("Oh no, RNGesus didn't generate such a number");
                }
            }
        }
    }
}