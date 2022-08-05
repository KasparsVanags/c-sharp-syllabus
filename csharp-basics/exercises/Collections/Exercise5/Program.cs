using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.Write("Enter a number: ");
                var numberInput = int.Parse(Console.ReadLine());
                if (IsHappy(numberInput))
                {
                    Console.WriteLine(numberInput + " is happy! :)");
                }
                else
                {
                    Console.WriteLine(numberInput + " is not happy :(");
                }
            }
        }
        
        static bool IsHappy(int number)
        {
            const int happy = 1;
            var checkedNumList = new List<int>();
            var tempNum = number;
            do
            {
                checkedNumList.Add(tempNum);
                tempNum = (int)tempNum.ToString().Select(x  => Math.Pow(x - '0', 2)).Sum();
            } while (tempNum != happy && !checkedNumList.Contains(tempNum));

            return tempNum == happy;
        }
    }
}