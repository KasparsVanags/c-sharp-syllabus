namespace ScooterRental.Exceptions;

public class ScooterAlreadyRentedException : Exception
{
    public ScooterAlreadyRentedException(string id) : base($"Scooter with id {id} already rented")
    {
    }
}