namespace ScooterRental.Tests;

public class ScooterTest
{
    private Scooter _scooter;
    
    [Fact]
    public void Scooter_OnCreation_HasValidInfo()
    {
        _scooter = new Scooter("1", 0.2m);
        _scooter.Id.Should().Be("1");
        _scooter.PricePerMinute.Should().Be(0.2m);
        _scooter.IsRented.Should().Be(false);
    }
}