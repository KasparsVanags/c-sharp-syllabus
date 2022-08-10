using System;

namespace AdApp
{
    public class Hoarding: Advert
    {
        private double _rate;
        private int _numDays;

        public Hoarding(int fee, int rate, int numDays, bool isPrimeLocation) : base(fee)
        {
            _rate = isPrimeLocation ? rate * 1.5 * 24 : rate * 24;
            _numDays = numDays;
        }

        public override double Cost()
        {
            return base.Cost() + TimeCost();
        }

        private double TimeCost()
        {
            return _rate * _numDays;
        }
        
        public override string ToString() 
        {
            return $"\nHoarding: Fee = {base.Cost()}, {_numDays} day cost = {TimeCost()}, Total = {Cost()}";
        }
    }
}