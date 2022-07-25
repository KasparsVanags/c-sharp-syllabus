using System;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private PhoneEntry[] _data;
        private int _dataCount;

        public PhoneDirectory() {
            _data = new PhoneEntry[1];
            _dataCount = 0;
        }

        private int Find(string name) {
            for (var i = 0; i < _dataCount; i++) 
            {
                if (_data[i].name.Equals(name)) 
                {
                    return i;
                }
            }

            return -1;
        }

        public string GetNumber(string name) 
        {
            var position = Find(name);
            if (position == -1) 
            {
                return null;
            } 
            else 
            {
                return _data[position].number;
            }
        }

        public void PutNumber(string name, string number) 
        {
            if (name == null || number == null) 
            {
                throw new Exception("name and number cannot be null");
            }

            var i = Find(name);
            if (i >= 0) 
            {
                _data[i].number = number;
            }
            else 
            {
                if (_dataCount == _data.Length) 
                {
                    Array.Resize(ref _data, (2 * _data.Length));
                }

                var newEntry = new PhoneEntry {name = name, number = number}; // Create a new pair.
                _data[_dataCount] = newEntry;   // Add the new pair to the array.
                _dataCount++;
            }
        }
    }
}