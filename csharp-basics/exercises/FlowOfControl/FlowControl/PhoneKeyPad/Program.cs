using System;

namespace PhoneKeyPad
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PhoneKeyPad();
        }

        static void PhoneKeyPad()
        {
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.WriteLine("Input text:");
                var stringInput = Console.ReadLine().ToLower();
                var result = "";
                foreach (var letter in stringInput)
                {
                    if (char.IsLetter(letter))
                    {
                        if (GetNumber(letter) != "0")
                        {
                            result += GetNumber(letter);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only letters are allowed!");
                        PhoneKeyPad();
                        return;
                    }
                }

                Console.WriteLine(stringInput + " converts to " + result);
            }
        }

        static string GetNumber(char letter)
        {
            switch (letter)
            {
                case 'a': case 'b': case 'c':
                    return "2";
                case 'd': case 'e': case 'f':
                    return "3";
                case 'g': case 'h': case 'i':
                    return "4";
                case 'j': case 'k': case 'l':
                    return "5";
                case 'm': case 'n': case 'o':
                    return "6";
                case 'p': case 'q': case 'r': case 's':
                    return "7";
                case 't': case 'u': case 'v':
                    return "8";
                case 'w': case 'x': case 'y': case 'z':
                    return "9";
                default:
                    return "0";
            }
        }
    }
}