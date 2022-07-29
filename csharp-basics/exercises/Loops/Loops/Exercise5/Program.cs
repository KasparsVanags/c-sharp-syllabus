using System;

namespace Exercis5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const int lineLenght = 30;
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.WriteLine("Enter the 1st word:");
                var firstWord = Console.ReadLine();
                Console.WriteLine("Enter the 2nd word:");
                var secondWord = Console.ReadLine();
                var numOfDots = lineLenght - firstWord.Length - secondWord.Length;
                Console.Write(firstWord);
                for (var i = 0; i < numOfDots; i++)
                {
                    Console.Write('.');
                }
                
                Console.WriteLine(secondWord);
            }
        }
    }
}