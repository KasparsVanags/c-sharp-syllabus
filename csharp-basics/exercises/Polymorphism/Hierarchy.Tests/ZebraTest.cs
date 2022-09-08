namespace Hierarchy.Tests;

[Collection("Sequential")]
public class ZebraTest : IDisposable
{
    private readonly Zebra _zebra;
    private readonly StringWriter _stringWriter;

    public ZebraTest()
    {
        _stringWriter = new StringWriter();
        Console.SetOut(_stringWriter);
        _zebra = new Zebra("Stripy", 50, "Africa");
    }
    [Fact]
    public void Zebra_CanBeCreated()
    {
        //Assert
        _zebra.Should().NotBeNull();
    }
    
    [Fact]
    public void Zebra_OnCreation_IsValid()
    {
        //Assert
        _zebra.ToString().Should().Be("Zebra[Stripy, 50, Africa, 0]");
    }

    [Fact]
    public void MakeSound_MakesMouseSounds()
    {
        //Act
        _zebra.MakeSound();
        //Assert
        _stringWriter.ToString().TrimEnd().Should().Be("* zebra sounds *");
    }

    [Fact]
    public void Eat_Vegetable_EatsVegetable()
    {
        //Act
        _zebra.Eat(new Vegetable(5));
        //Assert
        _zebra.ToString().Should().Be("Zebra[Stripy, 50, Africa, 5]");
    }
    
    [Fact]
    public void Eat_Meat_DoesntEatMeat()
    {
        //Act
        _zebra.Eat(new Meat(5));
        //Assert
        _stringWriter.ToString().Trim().Should().Be("Zebra are not eating that type of food!");
    }

    public void Dispose()
    {
        _stringWriter.Dispose();
    }
}