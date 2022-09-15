namespace Hierarchy.Tests;

[Collection("Sequential")]
public class CatTest
{
    private readonly StringWriter _stringWriter;
    private readonly Cat _cat;
    public CatTest()
    {
        _cat = new Cat("Mittens", 10, "house", "persian");
        _stringWriter = new StringWriter();
        Console.SetOut(_stringWriter);
    }
    
    [Fact]
    public void Cat_CanBeCreated()
    {
        //Assert
        _cat.Should().NotBeNull();
    }
    
    [Fact]
    public void Cat_OnCreation_IsValid()
    {
        //Assert
        _cat.ToString().Should().Be("Cat[Mittens, persian, 10, house, 0]");
    }

    [Fact]
    public void MakeSound_MakesCatSounds()
    {
        //Act
        _cat.MakeSound();
        //Assert
       _stringWriter.ToString().TrimEnd().Should().Be("Meowww");
    }
}