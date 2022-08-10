using System;

namespace Hierarchy
{
    public class Zebra : Mammal
    {
        public Zebra(string name, double weight, string region) : base(name, weight, region)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("* zebra sounds *");
        }

        public override void Eat(Food foodType)
        {
            if (foodType is Vegetable)
            {
                FoodEaten += foodType.Quantity;
            }
            else
            {
                Console.WriteLine(GetType().Name + " are not eating that type of food!");
            }
        }
    }
}