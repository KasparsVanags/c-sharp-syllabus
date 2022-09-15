using System;
using System.Collections.Generic;
using System.Linq;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        public readonly string[] AcceptedMoney = { "0,10 €", "0,20 €", "0,50 €", "1,00 €", "2,00 €" };
        public string Manufacturer { get; }
        public bool HasProducts => Array.Exists(Products, product => product.Available > 0);
        public Money Amount { get; private set; }
        public Product[] Products { get; set; }

        public VendingMachine(string manufacturer, int amountOfSlots)
        {
            Manufacturer = manufacturer;
            Products = new Product[amountOfSlots];
        }
        
        public Money InsertCoin(Money amount)
        {
            
            if (!AcceptedMoney.Contains(amount.ToString()))
            {
                return amount;
            }
            
            Amount = Amount.Add(amount);
            return new Money();
        }

        public Money ReturnMoney()
        {
            if (Amount.GetNumericValueInCents() == 0)
            {
                return Amount;
            } 
            
            var amountToReturn = Amount;
            Amount = new Money();
            Console.WriteLine($"{amountToReturn} returned");
            return amountToReturn;
        }

        public bool BuyProduct(int index)
        {
            var price = Products[index - 1].Price.GetNumericValueInCents();
            var balance = Amount.GetNumericValueInCents();
            if (Products[index - 1].Available < 1)
            {
                Console.WriteLine($"Sorry, that product is unavailable");
                return false;
            }
            
            if (price > balance)
            {
                Console.WriteLine($"Sorry, you can't afford that");
                return false;
            }

            Products[index - 1].Available += -1;
            Amount = Amount.Subtract(Products[index - 1].Price);
            Console.WriteLine($"Thank you, enjoy your {Products[index - 1].Name}");
            return true;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            var emptySlot = Array.FindIndex(Products, product => product.Name == null);
            if (emptySlot == -1)
            {
                Console.WriteLine("No free, unlabeled slots! Use \"Update product\"");
                return false;
            }

            var productToBeAdded = new Product(name, price, count);
            if (!ProductValidator.Validate(productToBeAdded))
            {
                return false;
            }
            
            Products[emptySlot] = productToBeAdded;
            Console.WriteLine($"Added {name} in slot {emptySlot + 1}");
            return true;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if (!IsProductIdValid(productNumber)) return false;
            if (!ProductValidator.Validate(new Product(name, price ?? new Money(1, 1), amount)))
            {
                return false;
            }
            
            if (price != null)
            {
                Products[productNumber - 1].Price = (Money)price;
            }

            Products[productNumber - 1].Name = name;
            Products[productNumber - 1].Available = amount;
            return true;
        }

        private bool IsProductIdValid(int productId)
        {
            if (productId >= 1 && productId <= Products.Length && Products[productId - 1].Name != null) return true;
            Console.WriteLine("Invalid product number");
            return false;
        }

        public string GetAvailableProducts()
        {
            if (!HasProducts)
            {
                return "This vending machine is empty";
            }

            var productList = new List<string>();
            for (var i = 0; i < Products.Length; i++)
            {
                if (Products[i].Available > 0)
                {
                    productList.Add($"{i + 1} - {Products[i]}");
                }
            }

            return string.Join("\n", productList);
        }
        
        public string GetAllProducts()
        {
            if (!HasProducts)
            {
                return "This vending machine is empty";
            }
            
            var productList = new List<string>();
            for (var i = 0; i < Products.Length; i++)
            {
                productList.Add(Products[i].Name == null ? $"{i + 1} - empty slot" : $"{i + 1} - {Products[i]}");
            }

            return string.Join("\n", productList);
        }
    }
}