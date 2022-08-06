using System;
using System.Collections.Generic;

namespace ListExercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");
            
            foreach (var element in colors) 
            {
              Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}
