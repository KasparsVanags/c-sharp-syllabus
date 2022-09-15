namespace ScooterRental.Exceptions;

public class InvalidPriceException : Exception
{
    public InvalidPriceException(decimal price) : base($"{price} is not a valid price")
    {
    }
}