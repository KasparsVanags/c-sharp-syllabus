using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercise8
{
    internal class Program
    {
        private static int numberOfGuesses = 8;
        private static int guessesRemaining;
        private static string word;
        private static char[] hiddenWord;
        private static string lettersTried;
        
        public static void Main(string[] args)
        {
            StartGame();
        }

        static void StartGame()
        {
            word = GetRandomWord().ToLower();
            hiddenWord = Regex.Replace(word, "[a-z]", "_").ToCharArray();
            guessesRemaining = numberOfGuesses;
            lettersTried = "";
            GetInput();
        }

        static void GuessLetter(char letter)
        {
            letter = char.ToLower(letter);
            if (word.IndexOf(letter) != -1)
            {
                for (var i = 0; i < word.Length; i++)
                {
                    if (word[i] == letter)
                    {
                        hiddenWord[i] = letter;
                    }
                }
                
                return;
            }

            if (lettersTried.Contains(letter))
            {
                return;
            }
            
            lettersTried += letter + " ";
            guessesRemaining--;
        }
        
        static string GetRandomWord()
        {
            string[] words = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\words.txt");
            var rand = new Random();
            return words[rand.Next(0, words.Length - 1)];
        }

        static void GetInput()
        {
            Draw();
            if (GameWon() || GameLost())
            {
                Console.WriteLine("Play again? y/n");
                var yesNo = char.ToLower(Console.ReadKey().KeyChar);
                if (yesNo == 'y')
                {
                    StartGame();
                    return;
                }
                if (yesNo == 'n')
                {
                    Console.WriteLine("\nThank you for playing. Exiting...");
                    Environment.Exit(0);
                }
                
                GetInput();
            }
            
            Console.Write("Your guess: ");
            var input = Console.ReadKey().KeyChar;
            if (!char.IsLetter(input))
            {
                Console.WriteLine("Only letters (a-z) are allowed");
                GetInput();
            }
            
            GuessLetter(input);
            GetInput();
        }
        
        static void Draw()
        {
            Console.WriteLine();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            DrawHangman();
            Console.WriteLine($"Guesses remaining: {guessesRemaining}/{numberOfGuesses}");
            Console.WriteLine("Letters already tried: " + lettersTried);
            Console.Write("Word: ");
            for (var i = 0; i < hiddenWord.Length; i++)
            {
                Console.Write(CheckLetter(i) + " ");
            }
            
            Console.WriteLine();
        }

        static void DrawHangman()
        {
            switch (guessesRemaining)
            {
                case 0:
                {
                    Console.WriteLine("   +---+   ");
                    Console.WriteLine("   |   |   ");
                    Console.WriteLine("   O   |   ");
                    Console.WriteLine(@"  /|\  |   ");
                    Console.WriteLine(@"  / \  |   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("===========");
                    break;
                }
                case 1:
                {
                    Console.WriteLine("   +---+   ");
                    Console.WriteLine("   |   |   ");
                    Console.WriteLine("   O   |   ");
                    Console.WriteLine(@"  /|\  |   ");
                    Console.WriteLine(@"  /    |   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("===========");
                    break;
                }
                case 2:
                {
                    Console.WriteLine("   +---+   ");
                    Console.WriteLine("   |   |   ");
                    Console.WriteLine("   O   |   ");
                    Console.WriteLine(@"  /|\  |   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("===========");
                    break;
                }
                case 3:
                {
                    Console.WriteLine("   +---+   ");
                    Console.WriteLine("   |   |   ");
                    Console.WriteLine("   O   |   ");
                    Console.WriteLine(@"  /|   |   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("===========");
                    break;
                }
                case 4:
                {
                    Console.WriteLine("   +---+   ");
                    Console.WriteLine("   |   |   ");
                    Console.WriteLine("   O   |   ");
                    Console.WriteLine("   |   |   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("===========");
                    break;
                }
                case 5:
                {
                    Console.WriteLine("   +---+   ");
                    Console.WriteLine("   |   |   ");
                    Console.WriteLine("   O   |   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("===========");
                    break;
                }
                case 6:
                {
                    Console.WriteLine("   +---+   ");
                    Console.WriteLine("   |   |   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("===========");
                    break;
                }
                case 7:
                {
                    Console.WriteLine("   +---+   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("       |   ");
                    Console.WriteLine("===========");
                    break;
                }
                case 8:
                {
                    Console.WriteLine("           ");
                    Console.WriteLine("           ");
                    Console.WriteLine("           ");
                    Console.WriteLine("           ");
                    Console.WriteLine("           ");
                    Console.WriteLine("           ");
                    Console.WriteLine("===========");
                    break;
                }
            }
        }

        static char CheckLetter(int index)
        {
            return hiddenWord[index];
        }

        static bool GameWon()
        {
            if (hiddenWord.Contains('_'))
            {
                return false;
            }
            
            Console.WriteLine("You won!");
            return true;
        }

        static bool GameLost()
        {
            if (guessesRemaining > 0)
            {
                return false;
            }
            
            Console.WriteLine("You lost!");
            return true;
        }
    }
}