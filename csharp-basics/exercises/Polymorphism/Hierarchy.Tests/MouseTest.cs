namespace Hierarchy.Tests;

[Collection("Sequential")]
public class MouseTest
{
    private readonly Mouse _mouse;
    private readonly StringWriter _stringWriter;

    public MouseTest()
    {
        _stringWriter = new StringWriter();
        Console.SetOut(_stringWriter);
        _mouse = new Mouse("Jerry", 10, "house");
    }
    
    [Fact]
    public void Mouse_CanBeCreated()
    {
        //Assert
        _mouse.Should().NotBeNull();
    }
    
    [Fact]
    public void Mouse_OnCreation_IsValid()
    {
        //Assert
        _mouse.ToString().Should().Be("Mouse[Jerry, 10, house, 0]");
    }

    [Fact]
    public void MakeSound_MakesMouseSounds()
    {
        //Act
        _mouse.MakeSound();
        //Assert
        _stringWriter.ToString().TrimEnd().Should().Be("Squeak!");
    }

    [Fact]
    public void Eat_Vegetable_EatsVegetable()
    {
        //Act
        _mouse.Eat(new Vegetable(5));
        //Assert
        _mouse.ToString().Should().Be("Mouse[Jerry, 10, house, 5]");
    }
    
    [Fact]
    public void Eat_Meat_DoesntEatMeat()
    {
        //Act
        _mouse.Eat(new Meat(5));
        //Assert
        _stringWriter.ToString().Trim().Should().Be("Mouse are not eating that type of food!");
    }
}