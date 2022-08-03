using System;

namespace Exercise3
{
    public class FuelGauge
    {
        private int _fuel;
        private const int FuelCapacity = 70;

        public FuelGauge(int fuel)
        {
            _fuel = fuel;
        }
        
        public int GetFuel()
        {
            return _fuel;
        }
        
        public void AddFuel(int fuel)
        {
            for (var i = 0; i < fuel; i++)
            {
                if (_fuel < FuelCapacity)
                {
                    _fuel++;
                    Console.WriteLine($"Fuel: {_fuel}/{FuelCapacity}");
                }
                else
                {
                    Console.WriteLine("Fuel tank is full!");
                    break;
                }
            }
        }

        public int BurnFuel()
        {
            if (_fuel > 0)
            {
                _fuel--;
            }

            return _fuel;
        }
    }
}