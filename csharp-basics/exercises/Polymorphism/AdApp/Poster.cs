namespace AdApp
{
    public class Poster : Advert
    {
        private readonly int _copies;
        private readonly double _costPerPoster;

        public Poster(int fee, int lengthInCm, int widthInCm, int copies, double ratePerSquareM) : base(fee)
        {
            _costPerPoster = lengthInCm * widthInCm * 0.0001 * ratePerSquareM;
            _copies = copies;
            
        }

        private double PosterCost()
        {
            return _costPerPoster * _copies;
        }

        public override double Cost()
        {
            return base.Cost() + PosterCost();
        }

        public override string ToString()
        {
            return $"\nPosters: Fee = {base.Cost()}, {_copies} poster cost = {PosterCost()}, Total = {Cost()}" ;
        }
    }
}