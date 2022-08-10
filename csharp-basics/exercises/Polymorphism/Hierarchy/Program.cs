using System;
using System.Collections.Generic;
using System.Linq;

namespace Hierarchy
{
    class Program
    {
        private static readonly List<Animal> AnimalList = new List<Animal>();
        
        static void Main(string[] args)
        {
            var waitingForInput = true;
            while (waitingForInput)
            {
                CreateAnimal();
                FeedAnimal();
            }
        }

        static void CreateAnimal()
        {
            Console.WriteLine("Input: Animal type, name, weight, region and breed(only for cats) separated by space");
            Console.WriteLine("Available animal types - Cat, Tiger, Zebra, Mouse");
            var inputs = GetInput();
            var animalType = Type.GetType("Hierarchy." + inputs[0]);
            if (animalType == typeof(Cat))
            {
                AnimalList.Add((Animal)Activator.CreateInstance(animalType, 
                    inputs[1], double.Parse(inputs[2]), inputs[3], inputs[4]));
            }
            else
            {
                AnimalList.Add((Animal)Activator.CreateInstance(animalType, 
                    inputs[1], double.Parse(inputs[2]), inputs[3]));
            }
            
            AnimalList.Last().MakeSound();
        }

        static void FeedAnimal()
        {
            Console.WriteLine("Enter food type and amount separated by space");
            Console.WriteLine("Available food types - Meat, Vegetable");
            var inputs = GetInput();
            var foodType = Type.GetType("Hierarchy." + inputs[0]);
            AnimalList.Last().Eat((Food)Activator.CreateInstance(foodType, int.Parse(inputs[1])));
        }

        static string[] GetInput()
        {
            Console.WriteLine("...or enter End to list all animals received");
            var input = Console.ReadLine().Split();
            if (input[0] == "End")
            {
                End();
            }
            
            return input;
        }

        static void End()
        {
            Console.WriteLine(string.Join(", ", AnimalList));
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}