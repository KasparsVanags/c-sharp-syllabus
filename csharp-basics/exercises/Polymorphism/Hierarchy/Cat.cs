using System;

namespace Hierarchy
{
    public class Cat : Feline
    {
        private readonly string _breed;

        public Cat(string name, double weight, string region, string breed) : base(name, weight, region)
        {
            _breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowww");
        }
        
        public override string ToString()
        {
            return $"{GetType().Name}[{Name}, {_breed}, {Weight}, {Region}, {FoodEaten}]";
        }
    }
}