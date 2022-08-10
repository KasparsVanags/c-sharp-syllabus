using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Janis", "Zarins", "Riga, Brivibas iela 1", 23592, 3.7);
            var employee = new Employee("Joe", "Biden", "White house", 12378, "President");
            student.Display();
            employee.Display();
            Console.ReadKey();
        }
    }
}