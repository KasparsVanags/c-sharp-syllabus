using ScooterRental.Exceptions;
using static ScooterRental.Constants;

namespace ScooterRental;

public static class IncomeCalculator
{
    public static decimal Income(DateTime startTime, DateTime endTime, decimal pricePerMinute)
    {
        if (endTime < startTime)
        {
            throw new InvalidDateException(endTime);
        }
        
        decimal income = 0;
        var daysBetween = Math.Ceiling((endTime.Date - startTime.Date).TotalDays - 1);
        if (startTime.Date.Equals(endTime.Date))
        {
            income = (decimal)(endTime - startTime).TotalMinutes * pricePerMinute;
            return income > MAX_RENT_COST_PER_DAY ? MAX_RENT_COST_PER_DAY : income;
        }

        var firstDayIncome = (decimal)(startTime.Date.AddDays(1) - startTime).TotalMinutes * pricePerMinute;
        var lastDayIncome = (decimal)(endTime - endTime.Date).TotalMinutes * pricePerMinute;
        income += firstDayIncome > MAX_RENT_COST_PER_DAY ? MAX_RENT_COST_PER_DAY : firstDayIncome;
        income += lastDayIncome > MAX_RENT_COST_PER_DAY ? MAX_RENT_COST_PER_DAY : lastDayIncome;
        for (var i = 0; i < daysBetween; i++)
        {
            var incomePerDay = 1440 * pricePerMinute;
            income += incomePerDay > MAX_RENT_COST_PER_DAY ? MAX_RENT_COST_PER_DAY : incomePerDay;
        }
        
        return income;
    }
}