namespace VendingMachine.Tests;

public class ProductTest
{
    [Fact]
    public void Product_OnCreation_IsValid()
    {
        //Arrange
        var price = new Money(0, 10);
        //Act
        var product = new Product("asd", price, 99);
        //Assert
        product.Name.Should().Be("asd");
        product.Price.Should().BeEquivalentTo(price);
        product.Available.Should().Be(99);
    }

    [Fact]
    public void ToString_IsCorrect()
    {
        //Arrange
        var price = new Money(0, 10);
        var product = new Product("asd", price, 99);
        //Assert
        product.ToString().Should().Be("asd - 0,10 € | 99 left");
    }
}