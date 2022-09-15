namespace ScooterRental.Exceptions;

public class ScooterListEmptyException : Exception
{
    public ScooterListEmptyException() : base("Scooter list is empty")
    {
    }
}