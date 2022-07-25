namespace AdApp
{
    public class TVAd: Advert
    {
        public TVAd(int fee) : base(fee)
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