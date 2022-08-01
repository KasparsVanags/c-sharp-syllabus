using System;

namespace Exercise3
{
    public class Odometer
    {
        private int _mileage;
        private const int OdoMax = 999999;
        private int _kmUtilLiterOfFuelBurned = 10;
        private readonly FuelGauge _fuelGauge;
        private const int KmPerLiter = 10;

        public Odometer(int mileage, FuelGauge fuelGauge)
        {
            _mileage = mileage;
            _fuelGauge = fuelGauge;
        }
        
        public int GetMileage()
        {
            return _mileage;
        }

        public bool IncrementMileage()
        {
            if (_mileage < OdoMax)
            {
                _mileage++;
            }
            else
            {
                _mileage = 0;
            }

            if (CarHasFuel())
            {
                return true;
            }
            
            Console.WriteLine("Out of fuel! Final mileage: " + _mileage);
            return false;
        }

        private bool CarHasFuel()
        {
            _kmUtilLiterOfFuelBurned--;
            if (_kmUtilLiterOfFuelBurned == 0)
            {
                _kmUtilLiterOfFuelBurned = KmPerLiter;
                if (_fuelGauge.BurnFuel() == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}