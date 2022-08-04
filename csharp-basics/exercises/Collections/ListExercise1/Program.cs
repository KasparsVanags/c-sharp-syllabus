using System;
using System.Collections.Generic;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colorList = new List<string> { "blue", "red" };
            Console.WriteLine("Input:");
            Console.WriteLine(string.Join(", ", colorList));
            Console.WriteLine("Added 5 colors:");
            colorList.Add("black");
            colorList.Add("white");
            colorList.Add("pink");
            colorList.Add("purple");
            colorList.Add("yellow");
            Console.WriteLine(string.Join(", ", colorList));
            Console.ReadKey();
        }
    }
}
