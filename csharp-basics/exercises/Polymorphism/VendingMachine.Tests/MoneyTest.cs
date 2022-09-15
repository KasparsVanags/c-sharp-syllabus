namespace VendingMachine.Tests;

public class MoneyTest
{
    [Fact]
    public void Money_CanBeCreated()
    {
        //Act
        var money = new Money(10, 20);
        //Assert
        money.ToString().Should().Be("10,20 €");
    }

    [Theory]
    [InlineData(10, 10, 10, 10, "20,20 €")]
    [InlineData(10, 10, -10, -10, "0,00 €")]
    [InlineData(10, 10, 0, 0, "10,10 €")]
    public void Add_Money_AddsMoney(int euros, int cents, int eurosToAdd, int centsToAdd, string result)
    {
        //Arrange
        var money = new Money(euros, cents);
        //Assert
        money.Add(new Money(eurosToAdd, centsToAdd)).ToString().Should().Be(result);
    }
    
    [Theory]
    [InlineData(10, 10, 10, 10, "0,00 €")]
    [InlineData(10, 10, -10, -10, "20,20 €")]
    [InlineData(10, 10, 0, 0, "10,10 €")]
    public void Subtract_Money_SubtractsMoney(int euros, int cents, int eurosToAdd, int centsToAdd, string result)
    {
        //Arrange
        var money = new Money(euros, cents);
        //Assert
        money.Subtract(new Money(eurosToAdd, centsToAdd)).ToString().Should().Be(result);
    }

    [Fact]
    public void GetNumericValueInCents_ReturnsValueInCents()
    {
        //Assert
        new Money(15, 15).GetNumericValueInCents().Should().Be(1515);
    }
}