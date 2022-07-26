using System;

namespace Exercise8
{
    internal class Program
    {
        const int normalHours = 40;
        const int maxHours = 60;
        const int minWage = 8;
        
        public static void Main(string[] args)
        {
            WageCalc(7.5, 35);
            WageCalc(8.2, 47);
            WageCalc(10, 73);
            Console.ReadKey();
        }
        
        static void WageCalc(double basePay, int hoursWorked)
        {
            var overtimePay = 1.5 * basePay;
            double wage;
            if (basePay < minWage)
            {
                Console.WriteLine($"Error. Minimum wage is ${minWage} per hour");
                return;
            }

            if (hoursWorked > maxHours)
            {
                Console.WriteLine($"Error. Maximum amount of hours = {maxHours}.");
                return;
            }

            if (hoursWorked <= normalHours)
            {
                wage = basePay * hoursWorked;
            }
            else
            {
                wage = basePay * hoursWorked + (hoursWorked - normalHours) * overtimePay;
            }
                
            Console.WriteLine($"Wage: ${wage}");
        }
    }
}