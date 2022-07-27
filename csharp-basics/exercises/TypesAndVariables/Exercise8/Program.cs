using System;

namespace Exercise8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.WriteLine("Input minutes to convert to years and days:");
                var minutesInput = TimeSpan.FromMinutes(long.Parse(Console.ReadLine()));
                var days = minutesInput.Days;
                const int daysInAYear = 365;
                var years = Math.Floor((decimal)days / daysInAYear);
                days %= daysInAYear;
                Console.WriteLine($"{years} year(s) and {days} day(s)");
            }
        }
    }
}