using Hierarchy.Exceptions;

namespace Hierarchy
{
    public abstract class Animal
    {
        protected int FoodEaten;
        protected readonly string Name;
        protected readonly double Weight;

        protected Animal(string name, double weight)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new InvalidNameException(nameof(name));
            }

            if (weight <= 0)
            {
                throw new NegativeValueException(nameof(weight));
            }
            
            Name = name;
            Weight = weight;
        }

        public abstract void MakeSound();

        public virtual void Eat(Food foodType)
        {
            if (foodType.Quantity <= 0)
            {
                throw new NegativeValueException(nameof(foodType.Quantity));
            }
            
            FoodEaten += foodType.Quantity;
        }
    }
}