using System;

namespace Persons
{
    public class Person
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string Address { get; set; }
        protected int Id { get; set; }

        public Person()
        {
        }

        protected Person(string firstName, string lastName, string address, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Id = id;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name: {FirstName}, last name: {LastName}, address: {Address}, id: {Id}");
        }
    }
}