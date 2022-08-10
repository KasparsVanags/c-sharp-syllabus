using System;

namespace Persons
{
    public class Student : Person
    {
        private double Gpa { get; set; }

        public Student(string firstName, string lastName, string address, int id, double gpa) :
            base(firstName, lastName, address, id)
        {
            Gpa = gpa;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {FirstName}, last name: {LastName}, address: {Address}, id: {Id}, GPA: {Gpa}");
        }
    }
}