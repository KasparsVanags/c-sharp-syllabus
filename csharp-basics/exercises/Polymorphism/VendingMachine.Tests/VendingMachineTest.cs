namespace VendingMachine.Tests;

public class VendingMachineTest
{
    private readonly VendingMachine _vend;
    private readonly Product _testProduct;
    public VendingMachineTest()
    {
        _vend = new VendingMachine("Venden", 5);
        _testProduct = new Product("cc", new Money(1, 0), 99);
    }
    
    [Fact]
    public void VendingMachine_OnCreation_IsValid()
    {
        //Act
        var vend = new VendingMachine("Venden", 5);
        //Assert
        vend.Manufacturer.Should().Be("Venden");
        vend.Products.Length.Should().Be(5);
        vend.HasProducts.Should().BeFalse();
        vend.Amount.ToString().Should().Be("0,00 €");
    }

    [Fact]
    public void InsertCoin_AcceptedCoin_AddsAmount()
    {
        //Act
        _vend.InsertCoin(new Money(0, 50));
        //Assert
        _vend.Amount.ToString().Should().Be("0,50 €");
    }
    
    [Fact]
    public void InsertCoin_MultipleAcceptedCoins_AddsAmount()
    {
        //Act
        _vend.InsertCoin(new Money(0, 50));
        //Assert
        _vend.Amount.ToString().Should().Be("0,50 €");
        //Act
        _vend.InsertCoin(new Money(1, 00));
        //Assert
        _vend.Amount.ToString().Should().Be("1,50 €");
        //Act
        _vend.InsertCoin(new Money(0, 10));
        //Assert
        _vend.Amount.ToString().Should().Be("1,60 €");
    }

    [Fact]
    public void InsertCoin_CoinNotAccepted_ThrowsInvalidCoinException()
    {
        //Arrange
        var invalidCoin = new Money(99, 99);
        //Assert
        _vend.InsertCoin(invalidCoin).Should().Be(invalidCoin);
    }

    [Fact]
    public void ReturnMoney_NoMoney_ReturnsNoMoney()
    {
        //Assert
        _vend.ReturnMoney().ToString().Should().Be("0,00 €");
    }
    
    [Fact]
    public void ReturnMoney_HasMoney_ReturnsMoney()
    {
        //Arrange
        _vend.InsertCoin(new Money(2, 00));
        //Assert
        _vend.ReturnMoney().ToString().Should().Be("2,00 €");
    }
    
    [Fact]
    public void ReturnMoney_MoneyReturned_AmountIsSetToZero()
    {
        //Arrange
        _vend.InsertCoin(new Money(2, 00));
        //Act
        _vend.ReturnMoney();
        //Assert
        _vend.Amount.ToString().Should().Be("0,00 €");
    }

    [Fact]
    public void AddProduct_FreeSlots_AddsProduct()
    {
        //Act
        _vend.AddProduct(_testProduct.Name, _testProduct.Price, _testProduct.Available);
        //Assert
        _vend.Products.Should().Contain(_testProduct);
    }

    [Fact]
    public void AddProduct_NoFreeSlots_ReturnsFalse()
    {
        //Arrange
        for (var i = 0; i < 5; i++)
        {
            _vend.AddProduct(_testProduct.Name, _testProduct.Price, _testProduct.Available);
        }

        //Assert
        _vend.AddProduct("abc", new Money(2, 00), 10).Should().BeFalse();
        _vend.Products.Should().NotContain(new Product("abc", new Money(2, 00), 10));
    }
    
    [Fact]
    public void AddProduct_InvalidName_ReturnsFalse()
    {
        //Assert
        _vend.AddProduct("", _testProduct.Price, _testProduct.Available).Should().BeFalse();
        _vend.Products.Should().NotContain(new Product("", _testProduct.Price, _testProduct.Available));
    }
    
    [Fact]
    public void AddProduct_InvalidPrice_ReturnsFalse()
    {
        //Assert
        _vend.AddProduct(_testProduct.Name, new Money(-1, 00), _testProduct.Available).Should().BeFalse();
        _vend.Products.Should()
            .NotContain(new Product(_testProduct.Name, new Money(-1, 00), _testProduct.Available));
    }
    
    [Fact]
    public void AddProduct_InvalidCount_ReturnsFalse()
    {
        //Assert
        _vend.AddProduct(_testProduct.Name, _testProduct.Price, -1).Should().BeFalse();
        _vend.Products.Should()
            .NotContain(new Product(_testProduct.Name, _testProduct.Price, -1));
    }

    [Fact]
    public void BuyProduct_EnoughMoneyProductAvailable_ReturnsTrue()
    {
        //Arrange
        ProductSetup();
        //Assert
        _vend.BuyProduct(1).Should().BeTrue();
    }
    
    [Fact]
    public void BuyProduct_EnoughMoneyProductAvailable_ProductIsBought()
    {
        //Arrange
        ProductSetup();
        //Assert
        _vend.BuyProduct(1).Should().BeTrue();
        _vend.Products[0].Available.Should().Be(98);
    }
    
    [Fact]
    public void BuyProduct_EnoughMoneyProductAvailable_AmountDeducted()
    {
        //Arrange
        ProductSetup();
        //Assert
        _vend.BuyProduct(1).Should().BeTrue();
        _vend.Amount.Should().BeEquivalentTo(new Money(1, 00));
    }

    [Fact]
    public void BuyProduct_NotEnoughMoney_ReturnsFalse()
    {
        //Arrange
        _vend.Products = new Product[] { new("cc", new Money(1, 00), 99) };
        //Assert
        _vend.BuyProduct(1).Should().BeFalse();
        _vend.Amount.Should().BeEquivalentTo(new Money(0, 00));

    }
    
    [Fact]
    public void BuyProduct_ProductNotAvailable_ReturnsFalse()
    {
        //Arrange
        _vend.Products = new Product[] { new("cc", new Money(1, 00), 0) };
        _vend.InsertCoin(new Money(2, 00));
        //Assert
        _vend.BuyProduct(1).Should().BeFalse();
        _vend.Amount.Should().BeEquivalentTo(new Money(2, 00));
    }
    
    [Fact]
    public void BuyProduct_ProductDoesntExist_ReturnsFalse()
    {
        //Arrange
        _vend.InsertCoin(new Money(2, 00));
        //Assert
        _vend.BuyProduct(1).Should().BeFalse();
        _vend.Amount.Should().BeEquivalentTo(new Money(2, 00));
    }

    [Fact]
    public void UpdateProduct_ProductExistsUpdateName_ProductIsUpdated()
    {
        //Arrange
        ProductSetup();
        //Assert
        _vend.UpdateProduct(1, "abc", null, 99).Should().BeTrue();
        _vend.Products[0].Name.Should().Be("abc");
    }
    
    [Fact]
    public void UpdateProduct_ProductDoesntExistUpdateName_ReturnsFalse()
    {
        //Assert
        _vend.UpdateProduct(1, "abc", null, 99).Should().BeFalse();
    }
    
    [Fact]
    public void UpdateProduct_EmptyName_ReturnsFalse()
    {
        //Arrange
        ProductSetup();
        //Assert
        _vend.UpdateProduct(1, "", null, 99).Should().BeFalse();
        _vend.Products[0].Name.Should().Be("cc");
    }
    
    [Fact]
    public void UpdateProduct_ProductExistsUpdateCount_ProductIsUpdated()
    {
        //Arrange
        ProductSetup();
        //Assert
        _vend.UpdateProduct(1, "cc", null, 50).Should().BeTrue();
        _vend.Products[0].Available.Should().Be(50);
    }

    [Fact]
    public void UpdateProduct_NegativeCount_ReturnsFalse()
    {
        //Arrange
        ProductSetup();
        //Assert
        _vend.UpdateProduct(1, "cc", null, -90).Should().BeFalse();
        _vend.Products[0].Available.Should().Be(99);
    }
    
    [Fact]
    public void UpdateProduct_ProductExistsUpdatePrice_ProductIsUpdated()
    {
        //Arrange
        ProductSetup();
        //Assert
        _vend.UpdateProduct(1, "cc", new Money(3, 00), 99).Should().BeTrue();
        _vend.Products[0].Price.Should().BeEquivalentTo(new Money(3, 00));
    }

    [Fact]
    public void UpdateProduct_NegativePrice_ReturnsFalse()
    {
        //Arrange
        ProductSetup();
        //Assert
        _vend.UpdateProduct(1, "cc", new Money(-3, 00), 99).Should().BeFalse();
        _vend.Products[0].Price.Should().BeEquivalentTo(new Money(1, 00));
    }

    [Fact]
    public void GetAllProducts_ProductsExist_ReturnsProducts()
    {
        //Arrange
        _vend.AddProduct("abc", new Money(1, 00), 2);
        _vend.AddProduct("asd", new Money(0, 50), 5);
        //Assert
        _vend.GetAllProducts().Should().Be
            ("1 - abc - 1,00 € | 2 left\n2 - asd - 0,50 € | 5 left\n3 - empty slot\n4 - empty slot\n5 - empty slot");
    }

    [Fact]
    public void GetAllProducts_NoProducts_ReturnsNoProducts()
    {
        //Assert
        _vend.GetAllProducts().Should().Be("This vending machine is empty");
    }
    
    [Fact]
    public void GetAvailableProducts_ProductsExist_ReturnsAvailableProducts()
    {
        //Arrange
        _vend.AddProduct("abc", new Money(1, 00), 2);
        _vend.AddProduct("asd", new Money(0, 50), 5);
        _vend.AddProduct("abcd", new Money(1, 00), 0);
        //Assert
        _vend.GetAvailableProducts().Should().Be
            ("1 - abc - 1,00 € | 2 left\n2 - asd - 0,50 € | 5 left");
    }

    [Fact]
    public void GetAvailableProducts_NoProducts_ReturnsNoProducts()
    {
        //Arrange
        _vend.AddProduct("abcd", new Money(1, 00), 0);
        //Assert
        _vend.GetAvailableProducts().Should().Be("This vending machine is empty");
    }

    private void ProductSetup()
    {
        _vend.Products = new [] { _testProduct };
        _vend.InsertCoin(new Money(2, 00));
    }
}