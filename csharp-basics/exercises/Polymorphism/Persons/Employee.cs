using System;

namespace Persons
{
    public class Employee : Person
    {
        private string JobTitle { get; set; }

        public Employee(string firstName, string lastName, string address, int id, string jobTitle) :
            base(firstName, lastName, address, id)
        {
            JobTitle = jobTitle;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {FirstName}, last name: {LastName}, address: {Address}, id: {Id}, job: {JobTitle}");
        }
    }
}