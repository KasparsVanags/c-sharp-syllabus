namespace AdApp
{
    public class TVAd: Advert
    {
        private int _seconds;
        private int _costPerSecond;
        
        public TVAd(int fee, int seconds, int costPerSecond, bool isPrimeTime) : base(fee)
        {
            _seconds = seconds;
            _costPerSecond = isPrimeTime ? costPerSecond * 2 : costPerSecond;
        }
        
        public override double Cost()
        {
            return base.Cost() + AirtimeCost();
        }

        private double AirtimeCost()
        {
            return _seconds * _costPerSecond;
        }
        
        public override string ToString()
        {
            return $"\nTV ad: Fee = {base.Cost()}, {_seconds} second airtime cost = {AirtimeCost()}, Total = {Cost()}";
        }
    }
}