using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Histogram
{
    class Program
    {
        private const string Path = "./midtermscores.txt";

        private static void Main(string[] args)
        {
            var histogram = new Dictionary<string, string>
            {
                {"00-09", ": "},
                {"10-19", ": "},
                {"20-29", ": "},
                {"30-39", ": "},
                {"40-49", ": "},
                {"50-59", ": "},
                {"60-69", ": "},
                {"70-79", ": "},
                {"80-89", ": "},
                {"90-99", ": "},
                {"  100", ": "},
            };
            
            var readText = File.ReadAllText(Path).Split(' ');
            foreach (var score in readText)
            {
                if (score == "100")
                {
                    histogram["  100"] += "*";
                }
                else
                {
                    for (var i = 0; i < histogram.Count - 1; i++)
                    {
                        var bracketRange = histogram.ElementAt(i).Key.Split('-');
                        if (int.Parse(score) >= int.Parse(bracketRange[0]) &&
                            int.Parse(score) <= int.Parse(bracketRange[1]))
                        {
                             histogram[histogram.ElementAt(i).Key] += "*";
                             break;
                        }
                    }
                }
            }
            
            foreach (var bracket in histogram)
            {
                Console.WriteLine(bracket.Key + bracket.Value);
            }

            Console.ReadKey();
        }
    }
}
