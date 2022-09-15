using ScooterRental.Exceptions;

namespace ScooterRental.Tests;

public class ScooterServiceTests
{
    private readonly IScooterService _scooterService;
    private readonly List<Scooter> _inventory;

    public ScooterServiceTests()
    {
        _inventory = new List<Scooter>();
        _scooterService = new ScooterService(_inventory);
    }

    [Fact]
    public void AddScooter_AddValidScooter_AddsScooter()
    {
        _scooterService.AddScooter("1", 0.2m);
        _inventory.Count.Should().Be(1);
    }

    [Fact]
    public void AddScooter_AddDuplicateScooter_ThrowsDuplicateScooterException()
    {
        //Arrange
        _scooterService.AddScooter("1", 0.2m);
        //Act
        Action act = () => _scooterService.AddScooter("1", 0.2m);
        //Assert
        act.Should().Throw<DuplicateScooterException>()
            .WithMessage("Scooter with id 1 already exists");
    }

    [Fact]
    public void AddScooter_AddScooterWithNegativePrice_ThrowsInvalidPriceException()
    {
        //Act
        Action act = () => _scooterService.AddScooter("1", -1);
        //Assert
        act.Should().Throw<InvalidPriceException>().WithMessage("-1 is not a valid price");
    }
    
    [Fact]
    public void AddScooter_AddScooterWithZeroPrice_ThrowsInvalidPriceException()
    {
        //Act
        Action act = () => _scooterService.AddScooter("1", 0);
        //Assert
        act.Should().Throw<InvalidPriceException>().WithMessage("0 is not a valid price");
    }

    [Fact]
    public void AddScooter_AddScooterWithNullOrEmptyId_ThrowsInvalidIdException()
    {
        //Act
        Action act = () => _scooterService.AddScooter("", 0.2m);
        //Assert
        act.Should().Throw<InvalidIdException>().WithMessage("id cannot be null or empty");
    }

    [Fact]
    public void RemoveScooter_ScooterExists_ScooterIsRemoved()
    {
        //Arrange
        _inventory.Add(new Scooter("1", 1));
        //Act
        _scooterService.RemoveScooter("1");
        //Assert
        _inventory.Any(s => s.Id == "1").Should().Be(false);
    }
    
    [Fact]  
    public void RemoveScooter_ScooterDoesntExist_ThrowsScooterDoesntExistException()
    {
        //Act
        Action act = () => _scooterService.RemoveScooter("1");
        //Assert
        act.Should().Throw<ScooterDoesNotExistException>().WithMessage("Scooter with id 1 does not exist");
    }

    [Fact]
    public void GetScooters_ScootersExist_ReturnsScooterList()
    {
        //Arranger
        var scooter1 = new Scooter("1", 1);
        var scooter2 = new Scooter("2", 2);
        _inventory.Add(scooter1);
        _inventory.Add(scooter2);
        //Assert
        _scooterService.GetScooters().Should().Contain(scooter1).And.Contain(scooter2);
    }
    
    [Fact]
    public void GetScooters_ScooterListEmpty_ThrowsScooterListEmptyException()
    {
        //Act
        Action act = () => _scooterService.GetScooters();
        //Assert
        act.Should().Throw<ScooterListEmptyException>().WithMessage("Scooter list is empty");
    }

    [Fact]
    public void GetScooterById_ScooterExists_ReturnsScooter()
    {
        //Arrange
        var scooter = new Scooter("1", 1);
        _inventory.Add(scooter);
        //Assert
        _scooterService.GetScooterById("1").Should().Be(scooter);
    }

    [Fact]
    public void GetScooterById_ScooterDoesntExist_ThrowsScooterDoesNotExistException()
    {
        //Act
        Action act = () => _scooterService.GetScooterById("asd");
        //Assert
        act.Should().Throw<ScooterDoesNotExistException>()
            .WithMessage("Scooter with id asd does not exist");
    }
}