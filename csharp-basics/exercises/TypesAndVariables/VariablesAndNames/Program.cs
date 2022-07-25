using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars, drivers, passengers, cars_not_driven, cars_driven;
            double seats_in_a_car, carpool_capacity, average_passengers_per_car;

            cars = 100; //cars
            seats_in_a_car = 4.0; //seats in a car
            drivers = 28; // drivers
            passengers = 90; // passengers
            //cars_not_driven  // free cars
            //cars_driven ; // cars driven at the moment
            //carpool_capacity = // carpool capacity
            //average_passengers_per_car = // average passengers per car

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + cars_not_driven + " empty cars today.");
            Console.WriteLine("We can transport " + carpool_capacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + average_passengers_per_car + " in each car.");
            Console.ReadKey();
        }
    }
}