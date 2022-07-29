using System;

namespace AsciiFigure
{
    internal class AsciiFigure
    {
        public static void Main(string[] args)
        {
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.WriteLine("How many lines to draw? (minimum - 2)");
                var numOfLines = int.Parse(Console.ReadLine());
                for (var mainIndex = 1; mainIndex <= numOfLines; mainIndex++)
                {
                    for (var slashIndex = mainIndex; slashIndex < numOfLines; slashIndex++)
                    {
                        Console.Write("////");
                    }
                    for (var asteriskIndex = mainIndex; asteriskIndex > 1; asteriskIndex--)
                    {
                        Console.Write("********");
                    }
                    for (var backSlashIndex = mainIndex; backSlashIndex < numOfLines; backSlashIndex++)
                    {
                        Console.Write(@"\\\\");
                    }
                    
                    Console.WriteLine();
                }
            }
        }
    }
}