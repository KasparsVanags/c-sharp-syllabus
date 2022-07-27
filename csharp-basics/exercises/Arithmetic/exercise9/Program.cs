using System;

namespace exercise9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CalculateBmi();
        }

        static void CalculateBmi()
        {
            const double minNormalBmi = 18.5;
            const double maxNormalBmi = 25;
            Console.WriteLine("Input your weight in kilograms.");
            if (int.TryParse(Console.ReadLine(), out int weight))
            {
                Console.WriteLine("Input your height in cm.");
                if (int.TryParse(Console.ReadLine(), out int height))
                {
                    double weightInPounds = weight * 2.2;
                    double heightInInches = height / 2.54;
                    double bmi = (weightInPounds * 703) / Math.Pow(heightInInches, 2);
                    string phrase = "have optimal weight";
                    if (bmi < minNormalBmi)
                    {
                        phrase = "are underweight";
                    }
                    else if (bmi > maxNormalBmi)
                    {
                        phrase = "are overweight";
                    }
                    
                    Console.WriteLine($"Your BMI is {bmi}, you {phrase}.");
                    return;
                }
            }
            
            Console.WriteLine("Error. You must input a number.");
            CalculateBmi();
        }
    }
}