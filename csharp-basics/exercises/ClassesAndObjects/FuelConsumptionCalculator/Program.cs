using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            double startKilometers;
            double liters;
            double endKilometers;
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.Write("Enter initial odo reading with a full gas tank: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());
                var car = new Car(startKilometers);
                Console.Write("Liters refilled: ");
                liters = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter odo reading: ");
                endKilometers = Convert.ToDouble(Console.ReadLine());
                car.FillUp(endKilometers, liters);
                Console.WriteLine(@"Kilometers per liter are " + car.CalculateConsumption() + 
                                  " gasHog: " + car.GasHog()+ ", economyCar: " + car.EconomyCar());
            }
        }
    }
}
