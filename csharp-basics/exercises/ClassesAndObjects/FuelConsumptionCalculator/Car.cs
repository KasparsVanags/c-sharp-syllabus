namespace FuelConsumptionCalculator
{
    public class Car
    {
        private readonly double _startKilometers;
        private double _endKilometers;
        private double _liters;
        
        public Car(double startOdo)
        {
            _startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return (_endKilometers - _startKilometers) / _liters;
        }

        public double ConsumptionPer100Km()
        {
            return 100 / CalculateConsumption();
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(double mileage, double liters)
        {
            _endKilometers = mileage;
            _liters = liters;
        }
    }
}
