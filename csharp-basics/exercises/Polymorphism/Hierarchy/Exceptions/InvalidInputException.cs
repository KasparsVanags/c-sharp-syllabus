using System;

namespace Hierarchy.Exceptions
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException() : base("Invalid input")
        {
        }
    }
}