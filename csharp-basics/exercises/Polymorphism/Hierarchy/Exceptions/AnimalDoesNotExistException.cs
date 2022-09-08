using System;

namespace Hierarchy.Exceptions
{
    public class AnimalDoesNotExistException : Exception
    {
        public AnimalDoesNotExistException(string animal) : base($"Animal {animal} does not exist")
        {
        }
    }
}