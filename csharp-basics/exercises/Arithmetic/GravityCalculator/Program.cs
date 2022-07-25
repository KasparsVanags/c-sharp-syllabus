using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const double gravity = -9.81;  //m/s^2
            const double initialVelocity = 0.0; //m/s
            const double fallingTime = 10.0; //s
            const double initialPosition = 0.0;
            double finalPosition = 0.5 * gravity * Math.Pow(fallingTime, 2) + initialVelocity * fallingTime + initialPosition;
            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
    }
}
