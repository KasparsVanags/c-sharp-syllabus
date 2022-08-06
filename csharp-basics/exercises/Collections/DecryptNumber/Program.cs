using System;
using System.Collections.Generic;
using System.Linq;

namespace DecryptNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cryptedNumbers = new List<string>
            {
                "())(",
                "*$(#&",
                "!!!!!!!!!!",
                "$*^&@!",
                "!)(^&(#@",
                "!)(#&%(*@#%"
            };
            
            Console.WriteLine("Encrypted: " + string.Join(", ", cryptedNumbers));
            var decryptedNumbers = cryptedNumbers.Select(Decrypt).ToList();
            Console.WriteLine("Decrypted: " + string.Join(", ", decryptedNumbers));
            Console.ReadKey();
        }
        
        static string Decrypt(string symbols)
        {
            var result = "";
            foreach (var symbol in symbols)
            {
                switch (symbol)
                {
                    case '!':
                        result += 1;
                        break;
                    case '@':
                        result += 2;
                        break;
                    case '#':
                        result += 3;
                        break;
                    case '$':
                        result += 4;
                        break;
                    case '%':
                        result += 5;
                        break;
                    case '^':
                        result += 6;
                        break;
                    case '&':
                        result += 7;
                        break;
                    case '*':
                        result += 8;
                        break;
                    case '(':
                        result += 9;
                        break;
                    case ')':
                        result += 0;
                        break;
                }
            }

            return result;
        }
    }
}