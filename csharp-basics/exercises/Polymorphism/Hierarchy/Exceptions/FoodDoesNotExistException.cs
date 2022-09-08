using System;

namespace Hierarchy.Exceptions
{
    public class FoodDoesNotExistException : Exception
    {
        public FoodDoesNotExistException(string food) : base($"Food {food} does not exist")
        {
        }
    }
}