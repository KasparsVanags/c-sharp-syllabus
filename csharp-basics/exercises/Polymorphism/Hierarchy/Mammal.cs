using Hierarchy.Exceptions;

namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        protected readonly string Region;

        public Mammal(string name, double weight, string region) : base(name, weight)
        {
            if (string.IsNullOrEmpty(region))
            {
                throw new InvalidNameException(nameof(region));
            }
            
            Region = region;
        }

        public override string ToString()
        {
            return $"{GetType().Name}[{Name}, {Weight}, {Region}, {FoodEaten}]";
        }
    }
}