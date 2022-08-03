using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercise13
{
    public class Smoothie
    {
        private static readonly Dictionary<string, decimal> IngredientPrices = new Dictionary<string, decimal>
        {
            {"Strawberries", (decimal)1.5},
            {"Banana", (decimal)0.5},
            {"Mango", (decimal)2.5},
            {"Blueberries", (decimal)1},
            {"Raspberries", (decimal)1},
            {"Apple", (decimal)1.75},
            {"Pineapple", (decimal)3.5}
        };
        
        private static readonly CultureInfo UnitedKingdom = CultureInfo.GetCultureInfo("en-GB");
        public readonly string[] Ingredients;
        private readonly decimal _cost = 0;

        public Smoothie(string[] ingredients)
        {
            Ingredients = ingredients;
            foreach (var ingredient in ingredients)
            {
                if (IngredientPrices.ContainsKey(ingredient))
                {
                    _cost += IngredientPrices[ingredient];
                }
            }
        }
        
        public string GetCost()
        {
            return _cost.ToString("C", UnitedKingdom);
        }

        public string GetPrice()
        {
            return Math.Round(_cost + _cost * (decimal)1.5, 2).ToString("C", UnitedKingdom);
        }

        public string GetName()
        {
            if (Ingredients.Length == 1)
            {
                return $"{Ingredients[0].Replace("berries", "berry")} Smoothie";
            }

            var ingredientNames = "";
            Array.Sort(Ingredients);
            foreach (var ingredient in Ingredients)
            {
                ingredientNames += ingredient.Replace("berries", "berry") + " ";
            }

            return $"{ingredientNames}Fusion";
        }
    }
}