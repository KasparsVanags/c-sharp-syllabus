namespace Hierarchy
{
    public abstract class Food
    {
        public int Quantity { get; set; }

        protected Food(int quantity)
        {
            Quantity = quantity;
        }
        
        public override string ToString()
        {
            return Quantity.ToString();
        }
    }
}