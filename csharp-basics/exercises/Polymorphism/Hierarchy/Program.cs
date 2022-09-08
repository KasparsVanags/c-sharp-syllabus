using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Hierarchy.Exceptions;

[assembly: InternalsVisibleTo("Hierarchy.Tests")]

namespace Hierarchy
{
    internal static class Program
    {
        private static readonly List<Animal> AnimalList = new List<Animal>();
        
        internal static void Main(string[] args)
        {
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.WriteLine("Input: Animal type, name, weight, region and breed(only for cats) separated by space");
                Console.WriteLine("Available animal types - Cat, Tiger, Zebra, Mouse");
                var inputs = GetInput();
                AnimalList.Add(CreateAnimal(inputs));
                AnimalList.Last().MakeSound();
                Console.WriteLine("Enter food type and amount separated by space");
                Console.WriteLine("Available food types - Meat, Vegetable");
                inputs = GetInput();
                AnimalList.Last().Eat(CreateFood(inputs));
            }
        }

        internal static Animal CreateAnimal(string[] inputs)
        {
            if (inputs.Length != 4 && inputs.Length != 5)
            {
                throw new InvalidInputException();
            }
            
            inputs = inputs.Select(x => x.Length > 1 ? char.ToUpper(x[0]) + x.Substring(1) : x.ToUpper()).ToArray();
            var animalType = Type.GetType("Hierarchy." + inputs[0]);
            if (animalType == null)
            {
                throw new AnimalDoesNotExistException(inputs[0]);
            }
            
            if (animalType == typeof(Cat))
            {
                return (Animal)Activator.CreateInstance(animalType, 
                    inputs[1], double.Parse(inputs[2]), inputs[3], inputs[4]);
            }
            
            return (Animal)Activator.CreateInstance(animalType,inputs[1], double.Parse(inputs[2]), inputs[3]);
        }

        internal static Food CreateFood(string[] inputs)
        {
            if (inputs.Length != 2)
            {
                throw new InvalidInputException();
            }
            
            var foodType = Type.GetType("Hierarchy." + inputs[0]);
            if (foodType == null)
            {
                throw new FoodDoesNotExistException(inputs[0]);
            }
            
            return (Food)Activator.CreateInstance(foodType, int.Parse(inputs[1]));
        }

        private static string[] GetInput()
        {
            Console.WriteLine("...or enter End to list all animals received");
            var input = Console.ReadLine().Split();
            if (input[0] == "End")
            {
                End();
            }
            
            return input;
        }

        private static void End()
        {
            Console.WriteLine(string.Join(", ", AnimalList));
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}