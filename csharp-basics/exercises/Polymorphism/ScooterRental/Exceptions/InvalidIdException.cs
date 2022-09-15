namespace ScooterRental.Exceptions;

public class InvalidIdException : Exception
{
    public InvalidIdException(string id) : base($"id cannot be null or empty")
    {
    }
}