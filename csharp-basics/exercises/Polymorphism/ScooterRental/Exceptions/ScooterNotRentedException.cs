namespace ScooterRental.Exceptions;

public class ScooterNotRentedException : Exception
{
    public ScooterNotRentedException(string id) : base($"Scooter id {id} not rented")
    {
    }
}