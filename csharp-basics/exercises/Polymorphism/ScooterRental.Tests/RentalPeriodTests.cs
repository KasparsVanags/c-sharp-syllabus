using ScooterRental.Exceptions;

namespace ScooterRental.Tests;

public class RentalPeriodTests
{
    private RentalPeriod _period;
    
    [Fact]
    public void RentalPeriod_OnCreation_HasValidInfo()
    {
        var start = new DateTime(2022, 8, 31, 16, 49, 00);
        _period = new RentalPeriod("1", 
            start, 0.2m);
        _period.StartTime.Should().Be(start);
        _period.EndTime.Should().Be(default);
        _period.ScooterId.Should().Be("1");
    }

    [Fact]
    public void GetIncome_ValidDate_ReturnsIncome()
    {
        //Arrange
        _period = new RentalPeriod("1", 
            new DateTime(2022, 8, 31, 16, 49, 00), 0.2m);
        //Assert
        _period.GetIncome(new DateTime(2022, 8, 31, 17, 49, 00)).Should().Be(12.0m);
    }

    [Fact]
    public void GetIncome_DateBeforeStartDate_ThrowsInvalidDateException()
    {
        //Arrange
        var date = new DateTime(1999, 1, 1);
        _period = new RentalPeriod("1", 
            new DateTime(2022, 8, 31, 16, 49, 00), 0.2m);
        //Act
        Action act = () => _period.GetIncome(date);
        //Assert
        act.Should().Throw<InvalidDateException>()
            .WithMessage($"Date {date} is before rental period start date");
    }

    [Fact]
    public void GetIncome_AtCurrentTimeWhenScooterNotRented_ThrowsScooterNotRentedException()
    {
        //Arrange
        var date = new DateTime(2022, 9, 1);
        _period = new RentalPeriod("1", 
            new DateTime(2022, 8, 31, 16, 49, 00), 0.2m)
        {
            EndTime = date
        };
        //Act
        Action act = () => _period.GetIncome(date + TimeSpan.FromHours(1));
        //Assert
        act.Should().Throw<ScooterNotRentedException>()
            .WithMessage($"Scooter id 1 not rented");
    }
    
    [Fact]
    public void GetIncome_PeriodNotFinished_ThrowsRentPeriodNotFinishedException()
    {
        //Arrange
        _period = new RentalPeriod("1", 
            new DateTime(2022, 8, 31, 16, 49, 00), 0.2m);
        //Act
        Action act = () => _period.GetIncome();
        //Assert
        act.Should().Throw<RentPeriodNotFinishedException>().WithMessage("Rent period id 1 not finished");
    }
}