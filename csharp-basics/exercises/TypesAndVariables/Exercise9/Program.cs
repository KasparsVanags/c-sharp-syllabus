using System;

namespace Exercise9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.Write("Input distance in meters: ");
                decimal meters = decimal.Parse(Console.ReadLine());
                decimal kilometers = meters / 1000;
                decimal miles = meters / 1609;
                Console.Write("Input hours: ");
                var time = TimeSpan.FromHours(int.Parse(Console.ReadLine()));
                Console.Write("Input minutes: ");
                time = time.Add(TimeSpan.FromMinutes(int.Parse(Console.ReadLine())));
                Console.Write("Input seconds: ");
                time = time.Add(TimeSpan.FromSeconds(int.Parse(Console.ReadLine())));
                var speedInMetersPerSecond = meters / (decimal)time.TotalSeconds;
                var speedInKilometersPerHour = kilometers / (decimal)time.TotalHours;
                var speedInMilesPerHour = miles / (decimal)time.TotalHours;
                
                Console.WriteLine("Your speed in meters/second is " + speedInMetersPerSecond);
                Console.WriteLine("Your speed in km/h is " + speedInKilometersPerHour);
                Console.WriteLine("Your speed in miles/h is " + speedInMilesPerHour);
            }
        }
    }
}