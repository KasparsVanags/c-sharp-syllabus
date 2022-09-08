namespace ScooterRental.Tests;

public class ScooterTest
{
    [Fact]
    public void Scooter_OnCreation_HasValidInfo()
    {
        //Act
        var scooter = new Scooter("1", 0.2m);
        //Assert
        scooter.Id.Should().Be("1");
        scooter.PricePerMinute.Should().Be(0.2m);
        scooter.IsRented.Should().Be(false);
    }
}