namespace ScooterRental.Exceptions;

public class RentPeriodNotFinishedException : Exception
{
    public RentPeriodNotFinishedException(string id) : base($"Rent period id {id} not finished")
    {
    }
}