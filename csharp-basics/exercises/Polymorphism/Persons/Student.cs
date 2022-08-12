using System;

namespace Persons
{
    public class Student : Person
    {
        private double _gpa;

        public Student(string firstName, string lastName, string address, int id, double gpa) :
            base(firstName, lastName, address, id)
        {
            _gpa = gpa;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {FirstName}, last name: {LastName}, address: {Address}, id: {Id}, GPA: {_gpa}");
        }
    }
}