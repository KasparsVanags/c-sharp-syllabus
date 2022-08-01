using System;

namespace Exercise14
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The day in dutch");
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.WriteLine("Input a date in yyyy mm dd format and press enter: ");
                var dateInput = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
                var year = dateInput[0];
                var month = dateInput[1];
                var day = dateInput[2];
                Console.WriteLine($"{year} {month} {day} is a \"{Date.WeekdayInDutch(year, month, day)}\" in dutch");
            }
        }
    }
}