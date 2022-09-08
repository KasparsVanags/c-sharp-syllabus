using System;

namespace Hierarchy.Exceptions
{
    public class NegativeValueException : Exception
    {
        public NegativeValueException(string name) : base($"{name} can't be 0 or less")
        {
        }
    }
}