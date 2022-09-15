using Hierarchy.Exceptions;
using Newtonsoft.Json;

namespace Hierarchy.Tests;

[Collection("Sequential")]
public class ProgramTest
{
    [Fact]
    public void CreateAnimal_ValidNonCatAnimal_CreatesAnimal()
    {
        //Arrange
        var a1 = JsonConvert.SerializeObject
            (new Tiger("Shiva", 100, "Africa"));
        //Act
        var a2 = JsonConvert.SerializeObject
            (Program.CreateAnimal(new[] { "Tiger", "Shiva", "100", "Africa" }));
        //Assert
        a1.Should().BeEquivalentTo(a2);
    }
    
    [Fact]
    public void CreateAnimal_ValidCat_CreatesCat()
    {
        //Arrange
        var a1 = JsonConvert.SerializeObject
            (new Cat("Tom", 100, "House", "Persian"));
        //Act
        var a2 = JsonConvert.SerializeObject
            (Program.CreateAnimal(new[] { "Cat", "Tom", "100", "House", "Persian" }));
        //Assert
        a1.Should().BeEquivalentTo(a2);
    }

    [Fact]
    public void CreateAnimal_NotEnoughParameters_ThrowsInvalidInputException()
    {
        //Act
        var act = () => Program.CreateAnimal(new[] { "Cat" });
        //Assert
        act.Should().Throw<InvalidInputException>();
    }
    
    [Fact]
    public void CreateAnimal_TooManyParameters_ThrowsInvalidInputException()
    {
        //Act
        var act = () => Program.CreateAnimal(new[] { "Cat", "Tom", "100", "House", "Persian", "asd" });
        //Assert
        act.Should().Throw<InvalidInputException>();
    }
    
    [Fact]
    public void CreateAnimal_InvalidAnimalType_ThrowsAnimalDoesNotExistException()
    {
        //Act
        var act = () => Program.CreateAnimal(new[] { "Unicorn", "Tom", "100", "House" });
        //Assert
        act.Should().Throw<AnimalDoesNotExistException>().WithMessage("Animal Unicorn does not exist");
    }

    [Fact]
    public void CreateFood_ValidFood_CreatesFood()
    {
        //Arrange
        var f1 = new Meat(100);
        //Act
        var f2 = Program.CreateFood(new[] { "Meat", "100" });
        //Assert
        f1.Should().BeEquivalentTo(f2);
    }

    [Fact]
    public void CreateFood_FoodDoesntExist_ThrowsFoodDoesNotExistException()
    {
        //Act
        var act = () => Program.CreateFood(new []{"Chocolate", "10"});
        //Assert
        act.Should().Throw<FoodDoesNotExistException>().WithMessage("Food Chocolate does not exist");
    }
    
    [Fact]
    public void CreateFood_NotEnoughParameters_ThrowsInvalidInputException()
    {
        //Act
        var act = () => Program.CreateFood(new[] { "Cat" });
        //Assert
        act.Should().Throw<InvalidInputException>();
    }
    
    [Fact]
    public void CreateFood_TooManyParameters_ThrowsInvalidInputException()
    {
        //Act
        var act = () => Program.CreateFood(new[] { "Cat", "Tom", "100", "House", "Persian", "asd" });
        //Assert
        act.Should().Throw<InvalidInputException>();
    }
}