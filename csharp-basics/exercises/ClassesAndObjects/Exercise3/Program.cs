using System;

namespace Exercise3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const int mileage = 100000;
            const int fuel = 10;
            var newFuelGauge = new FuelGauge(fuel);
            var newOdo = new Odometer(mileage, newFuelGauge);
            Console.WriteLine("Fuel: " + newFuelGauge.GetFuel() + " liters, how many liters do you want to add?");
            newFuelGauge.AddFuel(int.Parse(Console.ReadLine()));
            Console.WriteLine("Now we'll drive until out of fuel, press any key when ready");
            Console.ReadKey();
            Console.WriteLine();
            while (newOdo.IncrementMileage())
            {
                Console.WriteLine($"Mileage: {newOdo.GetMileage()}, fuel left: {newFuelGauge.GetFuel()}");
            }
            
            Console.ReadKey();
        }
    }
}