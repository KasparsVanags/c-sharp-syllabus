using ScooterRental.Exceptions;

namespace ScooterRental;

public class ScooterService : IScooterService
{
    private readonly IList<Scooter> _scooters;

    public ScooterService()
    {
        _scooters = new List<Scooter>();
    }
    
    public ScooterService(IList<Scooter> scooterList)
    {
        _scooters = scooterList;
    }
    
    public void AddScooter(string id, decimal pricePerMinute)
    {
        if (_scooters.Any(scooter => scooter.Id == id))
        {
            throw new DuplicateScooterException(id);
        }

        if (pricePerMinute <= 0)
        {
            throw new InvalidPriceException(pricePerMinute);
        }

        if (string.IsNullOrEmpty(id))
        {
            throw new InvalidIdException(id);
        }
        
        _scooters.Add(new Scooter(id, pricePerMinute));
    }

    public void RemoveScooter(string id)
    {
        var scooter = _scooters.FirstOrDefault(s => s.Id == id);
        if (scooter == null)
        {
            throw new ScooterDoesNotExistException(id);
        }
        
        _scooters.Remove(scooter);
    }

    public IList<Scooter> GetScooters()
    {
        if (!_scooters.Any())
        {
            throw new ScooterListEmptyException();
        }
        
        return _scooters;
    }

    public Scooter GetScooterById(string scooterId)
    {
        var scooter = _scooters.FirstOrDefault(s => s.Id == scooterId);
        if (scooter == null)
        {
            throw new ScooterDoesNotExistException(scooterId);
        }

        return scooter;
    }
}