namespace ScooterRental.Exceptions;

public class ScooterDoesNotExistException : Exception
{
    public ScooterDoesNotExistException(string id) : base($"Scooter with id {id} does not exist")
    {
    }
}