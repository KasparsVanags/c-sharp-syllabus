namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private readonly int _column;
        private readonly int _rate;

        public NewspaperAd(int fee, int column, int rate) : base(fee)
        {
            _column = column;
            _rate = rate;
        }

        public override double Cost()
        {
            return base.Cost() + ColumnCost();
        }

        private double ColumnCost()
        {
            return _rate * _column;
        }

        public override string ToString()
        {
            return $"\nNewspaper ad: Fee = {base.Cost()}, {_column} cm column cost = {ColumnCost()}, Total = {Cost()}" ;
        }
    }
}