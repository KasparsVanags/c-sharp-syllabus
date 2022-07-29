using System;

namespace Piglet
{
    internal class Piglet
    {
        public static void Main(string[] args)
        {
            var randomDice = new Random();
            PlayGame();
            
            void PlayGame()
            {
                Console.WriteLine("Welcome to Piglet!");
                var rollDice = true;
                var score = 0;
                while (rollDice)
                {
                    var numberRolled = randomDice.Next(1, 7);
                    score += numberRolled;
                    Console.WriteLine("You rolled a " + numberRolled + "!");
                    if (numberRolled == 1)
                    {
                        score = 0;
                        break;
                    }
                    Console.WriteLine("Roll again? y/n:");
                    if (Console.ReadLine().ToLower() == "n")
                    {
                        break;
                    }
                }
                
                Console.WriteLine("You got " + score + " points. Play again? y/n");
                if (Console.ReadLine().ToLower() == "y")
                {
                    PlayGame();
                }
            }
        }
    }
}