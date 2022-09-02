using ScooterRental.Exceptions;

namespace ScooterRental.Tests;

public class RentalCompanyTests : IDisposable
{
    private RentalCompany _company;
    private readonly ScooterService _service;
    private readonly List<RentalPeriod> _rentalPeriods;
    private readonly IList<Scooter> _scooters;

    public RentalCompanyTests()
    {
        SystemTime.SetDateTime(new DateTime(2022, 1, 1, 12, 0, 0));
        _scooters = new List<Scooter>();
        _service = new ScooterService(_scooters);
        _rentalPeriods = new List<RentalPeriod>();
        _company = new RentalCompany("Bolt", _service, _rentalPeriods);
    }
    
    [Fact]
    public void RentalCompany_ValidName_CanBeCreated()
    {
        _company = new RentalCompany("Bolt", new ScooterService());
        _company.Name.Should().Be("Bolt");
    }

    [Fact]
    public void RentalCompany_EmptyName_ThrowsInvalidNameException()
    {
        Action act = () => _company = new RentalCompany("", new ScooterService());
        Action act2 = () => _company = new RentalCompany("", new ScooterService(), new List<RentalPeriod>());
        act.Should().Throw<InvalidNameException>().WithMessage("Name cannot be null or empty");
        act2.Should().Throw<InvalidNameException>().WithMessage("Name cannot be null or empty");
    }

    [Fact]
    public void StartRent_ExistingScooter_StartsRentalPeriod()
    {
        _service.AddScooter("1", 1);
        _company.StartRent("1");
        _service.GetScooterById("1").IsRented.Should().Be(true);
        _rentalPeriods[0].ScooterId.Should().Be("1");
        _rentalPeriods[0].StartTime.Should().Be(SystemTime.Now());
    }

    [Fact]
    public void StartRent_ScooterDoesntExist_ThrowsScooterDoesNotExistException()
    {
        Action act = () => _company.StartRent("5");
        act.Should().Throw<ScooterDoesNotExistException>()
            .WithMessage("Scooter with id 5 does not exist");
    }

    [Fact]
    public void StartRent_ScooterAlreadyRented_ThrowsScooterAlreadyRentedException()
    {
        _service.AddScooter("1", 1);
        _company.StartRent("1");
        Action act = () => _company.StartRent("1");
        act.Should().Throw<ScooterAlreadyRentedException>()
            .WithMessage("Scooter with id 1 already rented");
    }

    [Fact]
    public void EndRent_ScooterRented_EndsRent()
    {
        SystemTime.SetDateTime(new DateTime(2022, 1, 1, 12, 0, 0));
        var scooter = new Scooter("1", 1)
        {
            IsRented = true
        };
        var period = new RentalPeriod("1", SystemTime.Now() - TimeSpan.FromMinutes(60), 1);
        _rentalPeriods.Add(period);
        _scooters.Add(scooter);
        _company.EndRent("1");
        scooter.IsRented.Should().Be(false);
        period.EndTime.Should().Be(SystemTime.Now());
        period.GetIncome().Should().Be(20);
    }

    [Fact]
    public void EndRent_ScooterDoesntExist_ThrowsScooterDoesNotExistException()
    {
        Action act = () => _company.EndRent("99");
        act.Should().Throw<ScooterDoesNotExistException>()
            .WithMessage("Scooter with id 99 does not exist");
    }

    [Fact]
    public void EndRent_ScooterNotRented_ThrowsScooterNotRentedException()
    {
        var scooter = new Scooter("5", 1)
        {
            IsRented = false
        };
        _scooters.Add(scooter);
        var period = new RentalPeriod("5", SystemTime.Now() - TimeSpan.FromMinutes(60), 1);
        _rentalPeriods.Add(period);
        Action act = () => _company.EndRent("5");
        act.Should().Throw<ScooterNotRentedException>().WithMessage("Scooter id 5 not rented");
    }
    
    [Fact]
    public void EndRent_ScooterNotRentedButWasRentedInPast_ThrowsScooterNotRentedException()
    {
        var scooter = new Scooter("5", 1)
        {
            IsRented = false
        };
        _scooters.Add(scooter);
        var period = new RentalPeriod("5", SystemTime.Now() - TimeSpan.FromMinutes(60), 1);
        _rentalPeriods.Add(period);
        period.EndTime = SystemTime.Now();
        Action act = () => _company.EndRent("5");
        act.Should().Throw<ScooterNotRentedException>().WithMessage("Scooter id 5 not rented");
    }

    [Fact]
    public void CalculateIncome_AllCompletedRentals_ReturnsIncome()
    {
        var date = new DateTime(2000, 1, 1);
        _rentalPeriods.Add(new RentalPeriod("1", date, 10));
        _rentalPeriods[0].EndTime = date.AddMinutes(10);
        _company.CalculateIncome(null, false).Should().Be(20);
    }
    
    [Fact]
    public void CalculateIncome_AllRentals_ReturnsIncome()
    {
        var date = SystemTime.Now() - TimeSpan.FromMinutes(10);
        _rentalPeriods.Add(new RentalPeriod("1", date, 1));
        _company.CalculateIncome(null, true).Should().Be(10);
    }

    [Fact]
    public void CalculateIncome_AllCompletedRentals_IsCorrect()
    {
        _rentalPeriods.AddRange(CompletedRentals.Select(x => (RentalPeriod)x[0]));
        var sum = CompletedRentals.Sum(x => (decimal)x[1]);
        _company.CalculateIncome(null, false).Should().Be(sum);
    }
    
    [Fact]
    public void CalculateIncome_AllRentalsIncludingIncompleteRentals_IsCorrect()
    {
        _rentalPeriods.AddRange(CompletedRentals.Select(x => (RentalPeriod)x[0]));
        var incompleteRentals = CompletedRentals.Select(x => (RentalPeriod)x[0]).ToList();
        incompleteRentals.ForEach(x => x.EndTime = default);
        _rentalPeriods.AddRange(incompleteRentals);
        var sum = CompletedRentals.Sum(x => (decimal)x[1]) 
                  + incompleteRentals.Sum(x => x.GetIncome(SystemTime.Now()));
        _company.CalculateIncome(null, true).Should().Be(sum);
    }

    [Theory]
    [InlineData(2021)]
    [InlineData(2020)]
    [InlineData(2019)]
    public void CalculateIncome_AllCompletedRentalsForSpecificYear_IsCorrect(int year)
    {
        _rentalPeriods.AddRange(CompletedRentals.Select(x => (RentalPeriod)x[0]));
        var incompleteRentals = CompletedRentals.Select(x => (RentalPeriod)x[0]).ToList();
        incompleteRentals.ForEach(x => x.EndTime = default);
        _rentalPeriods.AddRange(incompleteRentals);
        var sum = _rentalPeriods.Where(x => x.EndTime.Year == year).Sum(x => x.GetIncome());
        _company.CalculateIncome(year, false).Should().Be(sum);
    }
    
    [Theory]
    [InlineData(2021)]
    [InlineData(2020)]
    [InlineData(2019)]
    public void CalculateIncome_AllRentalsForSpecificYearWhenIncompleteRentalsWillEndInFuture_IsCorrect(int year)
    {
        _rentalPeriods.AddRange(CompletedRentals.Select(x => (RentalPeriod)x[0]));
        var incompleteRentals = CompletedRentals.Select(x => (RentalPeriod)x[0]).ToList();
        incompleteRentals.ForEach(x => x.EndTime = default);
        _rentalPeriods.AddRange(incompleteRentals);
        var sum = _rentalPeriods.Where(x => x.EndTime.Year == year).Sum(x => x.GetIncome());
        _company.CalculateIncome(year, true).Should().Be(sum);
    }
    
    [Fact]
    public void CalculateIncome_AllRentalsForSpecificYearWhenIncompleteRentalsWillEndThisYear_IsCorrect()
    {
        _rentalPeriods.AddRange(CompletedRentals.Select(x => (RentalPeriod)x[0]));
        var incompleteRentals = CompletedRentals.Select(x => (RentalPeriod)x[0]).ToList();
        incompleteRentals.ForEach(x => x.EndTime = default);
        _rentalPeriods.AddRange(incompleteRentals);
        var sum = _rentalPeriods.Where(x => x.EndTime.Year == SystemTime.Now().Year)
                      .Sum(x => x.GetIncome())
                  + incompleteRentals.Where(x => x.StartTime.Year == SystemTime.Now().Year)
                      .Sum(x => x.GetIncome(SystemTime.Now()));
        _company.CalculateIncome(SystemTime.Now().Year, true).Should().Be(sum);
    }
    
    private static IEnumerable<object[]> CompletedRentals =>
        new List<object[]>
        {
            new object[] {new RentalPeriod("1", 
                new DateTime(2020, 1, 1, 12, 0, 0), 0.1m)
            {
                EndTime = new DateTime(2020, 1, 1, 13, 0, 0)
            }, 6m},
            new object[] {new RentalPeriod("2", 
                new DateTime(2020, 1, 1, 12, 0, 0), 0.2m)
            {
                EndTime = new DateTime(2020, 1, 1, 14, 0, 0)
            }, 20m},
            new object[] {new RentalPeriod("3", 
                new DateTime(2020, 1, 1, 13, 0, 0), 0.3m)
            {
                EndTime = new DateTime(2020, 1, 1, 13, 10, 0)
            }, 3m},
            new object[] {new RentalPeriod("4", 
                new DateTime(2021, 1, 31, 23, 0, 0), 0.4m)
            {
                EndTime = new DateTime(2021, 2, 1, 0, 0, 0)
            }, 20m},
            new object[] {new RentalPeriod("5", 
                new DateTime(2019, 1, 1, 12, 0, 0), 0.5m)
            {
                EndTime = new DateTime(2019, 1, 1, 12, 20, 0)
            }, 10m},
            new object[] {new RentalPeriod("5", 
                new DateTime(2019, 12, 31, 23, 0, 0), 0.5m)
            {
                EndTime = new DateTime(2020, 1, 1, 1, 0, 0)
            }, 40m},
            new object[] {new RentalPeriod("5", 
                new DateTime(2022, 1, 1, 1, 0, 0), 0.5m)
            {
                EndTime = new DateTime(2022, 1, 1, 2, 0, 0)
            }, 20m}
        };

    public void Dispose()
    {
        SystemTime.ResetDateTime();
    }
}