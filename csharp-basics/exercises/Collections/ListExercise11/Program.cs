using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var carList = new List<string>
            {
                "Audi", "BMW", "Ferrari", "Ford", "Mercedes", "Opel", "Hennessey", "Kamaz", "Bugatti", "Volvo"
            };
            Console.WriteLine("A list of 10 elements:");
            Console.WriteLine(string.Join(" ", carList));
            carList.Insert(4, "Tesla");
            Console.WriteLine("New value at 5h position:");
            Console.WriteLine(string.Join(" ", carList));
            carList[carList.Count - 1] = "RollsRoyce";
            Console.WriteLine("Different value at last position:");
            Console.WriteLine(string.Join(" ", carList));
            carList.Sort();
            Console.WriteLine("Sorted list:");
            Console.WriteLine(string.Join(" ", carList));
            Console.WriteLine("Car list contains Foobar?: " + carList.Contains("Foobar"));
            Console.WriteLine("Print everything using a loop:");
            foreach (var car in carList)
            {
                Console.Write(car + " ");
            }

            Console.ReadKey();
        }
    }
}
