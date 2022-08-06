using System;
using System.Collections;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private readonly SortedList _data;

        public PhoneDirectory()
        {
            _data = new SortedList();
        }
        
        public string GetNumber(string name)
        {
            return _data.ContainsKey(name) ? (string)_data[name] : "Number not found";
        }

        public void PutNumber(string name, string number) 
        {
            if (name == null || number == null) 
            {
                throw new Exception("Name and number cannot be null");
            }

            try
            {
                _data.Add(name, number);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Number already added");
            }
        }

        public void DeleteNumber(string name)
        {
            _data.Remove(name);
        }
        
        public ICollection GetNames()
        {
            return _data.Keys;
        }

        public void EditNumber(string name, string newNumber)
        {
            _data[name] = newNumber;
        }
    }
}