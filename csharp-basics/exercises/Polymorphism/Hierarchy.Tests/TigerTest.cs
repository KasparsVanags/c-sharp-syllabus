namespace Hierarchy.Tests;

[Collection("Sequential")]
public class TigerTest : IDisposable
{
    private readonly Tiger _tiger;
    private readonly StringWriter _stringWriter;

    public TigerTest()
    {
        _stringWriter = new StringWriter();
        Console.SetOut(_stringWriter);
        _tiger = new Tiger("Shiva", 100, "Africa");
    }
    
    [Fact]
    public void Tiger_CanBeCreated()
    {
        //Assert
        _tiger.Should().NotBeNull();
    }
    
    [Fact]
    public void Tiger_OnCreation_IsValid()
    {
        //Assert
        _tiger.ToString().Should().Be("Tiger[Shiva, 100, Africa, 0]");
    }

    [Fact]
    public void MakeSound_MakesSounds()
    {
        //Act
        _tiger.MakeSound();
        //Assert
        _stringWriter.ToString().TrimEnd().Should().Be("ROAAR!!!");
    }

    [Fact]
    public void Eat_Vegetable_DoesntEatVegetables()
    {
        //Act
        _tiger.Eat(new Meat(5));
        //Assert
        _tiger.ToString().Should().Be("Tiger[Shiva, 100, Africa, 5]");
    }
    
    [Fact]
    public void Eat_Meat_EatsMeat()
    {
        //Act
        _tiger.Eat(new Vegetable(5));
        //Assert
        _stringWriter.ToString().Trim().Should().Be("Tiger are not eating that type of food!");
    }

    public void Dispose()
    {
        _stringWriter.Dispose();
    }
}