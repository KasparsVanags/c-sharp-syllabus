namespace Hierarchy
{
    public abstract class Animal
    {
        protected int FoodEaten;
        protected readonly string Name;
        protected readonly double Weight;

        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public abstract void MakeSound();

        public virtual void Eat(Food foodType)
        {
            FoodEaten += foodType.Quantity;
        }
    }
}