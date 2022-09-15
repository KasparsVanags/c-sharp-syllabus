using ScooterRental.Exceptions;

namespace ScooterRental;

public class RentalCompany : IRentalCompany
{
    public string Name { get; }
    private readonly IList<RentalPeriod> _rentalPeriods;
    private readonly ScooterService _scooterService;

    public RentalCompany(string name, ScooterService scooterService)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new InvalidNameException();
        }
        
        Name = name;
        _rentalPeriods = new List<RentalPeriod>();
        _scooterService = scooterService;
    }
    
    public RentalCompany(string name, ScooterService scooterService, IList<RentalPeriod> rentalPeriods)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new InvalidNameException();
        }
        
        Name = name;
        _rentalPeriods = rentalPeriods;
        _scooterService = scooterService;
    }
    
    public void StartRent(string id)
    {
        var scooter = _scooterService.GetScooterById(id);
        if (scooter.IsRented)
        {
            throw new ScooterAlreadyRentedException(id);
        }
        
        _rentalPeriods.Add(new RentalPeriod(id, SystemTime.Now(), scooter.PricePerMinute));
        scooter.IsRented = true;
    }

    public decimal EndRent(string id)
    {
        var period = _rentalPeriods.LastOrDefault(x => x.ScooterId == id);
        if (_scooterService.GetScooterById(id).IsRented == false || period == null)
        {
            throw new ScooterNotRentedException(id);
        }
        
        period.EndTime = SystemTime.Now();
        _scooterService.GetScooterById(id).IsRented = false;
        return period.GetIncome();
    }

    public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
    {
        decimal completedRentals;
        if (year == null)
        {
            completedRentals = _rentalPeriods.Where(x => x.EndTime != default)
                .Sum(x => x.GetIncome());
        }
        else
        {
            completedRentals = _rentalPeriods.Where(x => x.EndTime.Year == year)
                .Sum(x => x.GetIncome());
        }

        if (!includeNotCompletedRentals) return completedRentals;
        {
            decimal incompleteRentals;
            if (year == null)
            {
                incompleteRentals = _rentalPeriods.Where(x => x.EndTime == default)
                    .Sum(x => x.GetIncome(SystemTime.Now()));
            }
            else
            {
                incompleteRentals = _rentalPeriods
                    .Where(x => x.StartTime.Year == year 
                                && x.StartTime.Year == SystemTime.Now().Year 
                                && x.EndTime == default)
                    .Sum(x => x.GetIncome(SystemTime.Now()));
            }

            return completedRentals + incompleteRentals;
        }
    }
}