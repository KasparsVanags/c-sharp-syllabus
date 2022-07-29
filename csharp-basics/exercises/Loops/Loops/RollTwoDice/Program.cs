using System;

namespace RollTwoDice
{
    internal class RollTwoDice 
    {
        public static void Main(string[] args)
        {
            var waitingForInput = true;
            while (waitingForInput)
            {
                var rollDice = new Random();
                Console.WriteLine("Desired sum:");
                var targetSum = int.Parse(Console.ReadLine());
                if (targetSum > 12 || targetSum < 2)
                {
                    Console.WriteLine("Sum must be 2 - 12");
                    continue;
                }
                var sum = 0;
                while (sum != targetSum)
                {
                    var dice1 = rollDice.Next(1, 7);
                    var dice2 = rollDice.Next(1, 7);
                    sum = dice1 + dice2;
                    Console.WriteLine($"{dice1} and {dice2} = {sum}");
                }
            }
        }
    }
}