using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName, myEyes, myTeeth, myHair;
            int myAge, myHeight, myWeight;

            myName = "Zed A. Shaw";
            myAge = 35;
            myHeight = 74;  // inches
            myWeight = 180; // lbs
            myEyes = "Blue";
            myTeeth = "White";
            myHair = "Brown";

            Console.WriteLine("Let's talk about " + myName + ".");
            Console.WriteLine("He's " + myHeight + " inches tall.");
            Console.WriteLine("He's " + myWeight + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + myEyes + " eyes and " + myHair + " hair.");
            Console.WriteLine("His teeth are usually " + myTeeth + " depending on the coffee.");

            Console.WriteLine("If I add " + myAge + ", " + myHeight + ", and " + myWeight
                               + " I get " + (myAge + myHeight + myWeight) + ".");

            Console.ReadKey();
        }
    }
}