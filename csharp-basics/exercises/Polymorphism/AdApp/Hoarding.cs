namespace AdApp
{
    public class Hoarding: Advert
    {
        private int rate;
        //per day
        private int numDays;

        public Hoarding(int fee) : base(fee)
        {
        }

        public new int Cost() 
        {
            return base.Cost();
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}