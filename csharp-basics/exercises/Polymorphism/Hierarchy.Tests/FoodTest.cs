namespace Hierarchy.Tests;

public class FoodTest
{
    private class TestFood : Food
    {
        public TestFood(int quantity) : base(quantity)
        {
        }
    }

    [Fact]
    public void Food_CanBeCreated()
    {
        //Act
        var food = new TestFood(1);
        //Assert
        food.Should().NotBeNull();
    }
    
    [Fact]
    public void Food_OnCreation_IsCorrect()
    {
        //Act
        var food = new TestFood(10);
        //Assert
        food.Quantity.Should().Be(10);
        food.ToString().Should().Be("10");
    }
}