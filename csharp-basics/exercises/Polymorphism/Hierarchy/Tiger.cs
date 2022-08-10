using System;

namespace Hierarchy
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string region) : base(name, weight, region)
        {
        }
        
        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override void Eat(Food foodType)
        {
            if (foodType is Meat)
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