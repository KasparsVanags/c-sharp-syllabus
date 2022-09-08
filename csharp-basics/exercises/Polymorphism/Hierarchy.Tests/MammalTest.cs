using Hierarchy.Exceptions;

namespace Hierarchy.Tests;

public class MammalTest
{
    private class TestMammal : Mammal
    {
        public string TestRegion => Region;
        public TestMammal(string name, double weight, string region) : base(name, weight, region)
        {
        }

        public override void MakeSound()
        {
        }
    }

    [Fact]
    public void Mammal_CanBeCreated()
    {
        //Act
        var mammal = new TestMammal("Donkey", 100, "Africa");
        //Assert
        mammal.Should().NotBeNull();
    }
    
    [Fact]
    public void Mammal_OnCreation_IsValid()
    {
        //Act
        var mammal = new TestMammal("Donkey", 100, "Africa");
        //Assert
        mammal.TestRegion.Should().Be("Africa");
    }
    
    [Fact]
    public void Region_Empty_ThrowsInvalidNameException()
    {
        //Act
        var act = () => new TestMammal("Donkey", 100, "");
        //Assert
        act.Should().Throw<InvalidNameException>().WithMessage("Region can't be null or empty");
    }
    
    [Fact]
    public void ToString_ReturnsCorrectInfo()
    {
        //Arrange
        var mammal = new TestMammal("Donkey", 100, "Africa");
        //Assert
        mammal.ToString().Should().Be("TestMammal[Donkey, 100, Africa, 0]");
    }
}