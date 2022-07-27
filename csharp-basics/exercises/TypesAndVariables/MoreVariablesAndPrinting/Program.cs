using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Zed A. Shaw";
            var age = 35;
            var heightInInches = 74;
            var heightInCentimeters = Math.Round(heightInInches * 2.54, 2);
            var weightInPounds = 180;
            var weightInKilos = Math.Round(weightInPounds * 0.453592, 2);
            var eyes = "Blue";
            var teeth = "White";
            var hair = "Brown";

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + heightInCentimeters + " cm tall.");
            Console.WriteLine("He's " + weightInKilos + " kg heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");
            Console.WriteLine("If I add " + age + ", " + heightInInches + ", and " + weightInPounds
                              + " I get " + (age + heightInInches + weightInPounds) + ".");
            Console.ReadKey();
        }
    }
}