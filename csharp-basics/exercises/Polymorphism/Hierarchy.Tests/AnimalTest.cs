using Hierarchy.Exceptions;

namespace Hierarchy.Tests;

public class AnimalTest
{
    private class TestAnimal : Animal
    {
        public int TestFoodEaten => FoodEaten;
        public string TestName => Name;
        public double TestWeight => Weight;
        
        public TestAnimal(string name, double weight) : base(name, weight)
        {
        }

        public override void MakeSound()
        {
        }
    }
    
    [Fact]
    public void Animal_OnCreation_IsNormal()
    {
        //Act
        var animal = new TestAnimal("Dog", 100);
        //Assert
        animal.TestFoodEaten.Should().Be(0);
        animal.TestName.Should().Be("Dog");
        animal.TestWeight.Should().Be(100);
    }
    
    [Fact]
    public void Animal_NameEmpty_ThrowsInvalidNameException()
    {
        //Act
        var act = () => new TestAnimal("", 100);
        //Assert
        act.Should().Throw<InvalidNameException>().WithMessage("name can't be null or empty");
    }
    
    [Fact]
    public void Animal_WeightZero_ThrowsInvalidWeightException()
    {
        //Act
        var act = () => new TestAnimal("Dog", 0);
        //Assert
        act.Should().Throw<NegativeValueException>().WithMessage("Weight can't be 0 or less");
    }
    
    [Fact]
    public void Animal_WeightNegative_ThrowsInvalidWeightException()
    {
        //Act
        var act = () => new TestAnimal("Dog", -10);
        //Assert
        act.Should().Throw<NegativeValueException>().WithMessage("Weight can't be 0 or less");
    }
    
    [Fact]
    public void Feed_Food_IncreasesFoodEaten()
    {
        //Arrange
        var animal = new TestAnimal("Dog", 100);
        //Act
        animal.Eat(new Meat(10));
        //Assert
        animal.TestFoodEaten.Should().Be(10);
    }
    
    [Fact]
    public void Feed_ZeroFood_ThrowsInvalidFoodException()
    {
        //Arrange
        var animal = new TestAnimal("Dog", 100);
        //Act
        var act = () => animal.Eat(new Meat(0));
        //Assert
        act.Should().Throw<NegativeValueException>().WithMessage("Quantity can't be 0 or less");
    }
    
    [Fact]
    public void Feed_NegativeFood_ThrowsInvalidFoodException()
    {
        //Arrange
        var animal = new TestAnimal("Dog", 100);
        //Act
        var act = () => animal.Eat(new Meat(-10));
        //Assert
        act.Should().Throw<NegativeValueException>().WithMessage("Quantity can't be 0 or less");
    }
}