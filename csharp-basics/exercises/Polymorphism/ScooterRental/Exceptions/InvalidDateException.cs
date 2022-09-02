namespace ScooterRental.Exceptions;

public class InvalidDateException : Exception
{
    public InvalidDateException(DateTime date) : base($"Date {date} is before rental period start date")
    {
    }
}