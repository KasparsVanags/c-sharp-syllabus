using System;

namespace Exercise13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var s1 = new Smoothie(new string[] { "Banana" });
            Console.WriteLine("Name: " + s1.GetName());
            Console.WriteLine("Ingredients: " + ListIngredients(s1.Ingredients));
            Console.WriteLine("Cost: " + s1.GetCost());
            Console.WriteLine("Price: " + s1.GetPrice());
            var s2 = new Smoothie(new string[] { "Raspberries", "Strawberries", "Blueberries" });
            Console.WriteLine("Name: " + s2.GetName());
            Console.WriteLine("Ingredients: " + ListIngredients(s2.Ingredients));
            Console.WriteLine("Cost: " + s2.GetCost());
            Console.WriteLine("Price: " + s2.GetPrice());
            Console.ReadKey();

            string ListIngredients(string[] ingredients)
            {
                return string.Join(", ", ingredients);
            }
        }
    }
}