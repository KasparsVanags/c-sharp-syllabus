using System;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;
        private static void Main(string[] args)
        {
            var energyDrinkers = CalculateEnergyDrinkers();
            var preferCitrus = CalculatePreferCitrus();
            Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
            Console.WriteLine("Approximately " + Math.Round(energyDrinkers) + " bought at least one energy drink");
            Console.WriteLine(Math.Round(preferCitrus) + " of those " + "prefer citrus flavored energy drinks.");
            Console.ReadKey();
        }

        static double CalculateEnergyDrinkers()
        {
            return NumberedSurveyed * PurchasedEnergyDrinks;
        }

        static double CalculatePreferCitrus()
        {
            return NumberedSurveyed * PurchasedEnergyDrinks * PreferCitrusDrinks;
        }
    }
}
