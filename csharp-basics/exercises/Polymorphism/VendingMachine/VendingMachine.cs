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
            if (AcceptedMoney.Contains(amount.ToString()))
            {
                Amount = Amount.Add(amount);
                return Amount;
            }
            
            Console.WriteLine($"Sorry, we accept only {string.Join(" | ", AcceptedMoney)} coins");
            return amount;
        }

        public bool BuyProduct(int index)
        {
            var price = Products[index - 1].Price.NumericValue();
            var balance = Amount.NumericValue();
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
            ReturnMoney();
            return true;
        }
        
        public Money ReturnMoney()
        {
            if (Amount.NumericValue() == 0)
            {
                return Amount;
            }
            
            var amountToReturn = Amount;
            Amount = new Money();
            Console.WriteLine($"{amountToReturn} returned");
            return amountToReturn;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            var emptySlot = Array.FindIndex(Products, product => product.Name == null);
            if (emptySlot == -1)
            {
                Console.WriteLine("No free, unlabeled slots! Use \"Update product\"");
                return false;
            }

            Products[emptySlot] = new Product(name, price, count);
            Console.WriteLine($"Added {name} in slot {emptySlot + 1}");
            return true;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if (productNumber < 1 || productNumber > Products.Length)
            {
                Console.WriteLine("Invalid product number");
                return false;
            }
            
            Products[productNumber - 1].Name = name;
            if (price != null) Products[productNumber - 1].Price = (Money)price;
            Products[productNumber - 1].Available = amount;
            return true;
        }
        
        public bool UpdateProduct(int productNumber, int amount)
        {
            if (productNumber < 1 || productNumber > Products.Length)
            {
                Console.WriteLine("Invalid product number");
                return false;
            }
            
            Products[productNumber - 1].Available = amount;
            return true;
        }

        public bool UpdateProduct(int productNumber, Money price)
        {
            if (productNumber < 1 || productNumber > Products.Length)
            {
                Console.WriteLine("Invalid product number");
                return false;
            }
            
            Products[productNumber - 1].Price = price;
            return true;
        }
        
        public bool UpdateProduct(int productNumber, string name)
        {
            if (productNumber < 1 || productNumber > Products.Length)
            {
                Console.WriteLine("Invalid product number");
                return false;
            }
            
            Products[productNumber - 1].Name = name;
            return true;
        }

        public bool HasFreeSlots()
        {
            return Array.FindIndex(Products, product => product.Name == null) != -1;
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