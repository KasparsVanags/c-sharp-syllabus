using System;

namespace Hierarchy.Exceptions
{
    public class InvalidNameException : Exception
    {
        public InvalidNameException(string name) : base($"{name} can't be null or empty")
        {
        }
    }
}