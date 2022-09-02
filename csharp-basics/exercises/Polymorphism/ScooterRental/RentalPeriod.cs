using ScooterRental.Exceptions;

namespace ScooterRental;

public class RentalPeriod
{
    public readonly string ScooterId;
    public readonly DateTime StartTime;
    private readonly decimal _pricePerMinute;
    public DateTime EndTime;
    
    public RentalPeriod(string scooterId, DateTime startTime, decimal pricePerMinute)
    {
        ScooterId = scooterId;
        StartTime = startTime;
        _pricePerMinute = pricePerMinute;
    }

    public decimal GetIncome(DateTime periodEndTime)
    {
        if (EndTime != default)
        {
            throw new ScooterNotRentedException(ScooterId);
        }

        return IncomeCalculator.Income(StartTime, periodEndTime, _pricePerMinute);
    }
    
    public decimal GetIncome()
    {
        if (EndTime == default)
        {
            throw new RentPeriodNotFinishedException(ScooterId);
        }
        
        return IncomeCalculator.Income(StartTime, EndTime, _pricePerMinute);
    }
}