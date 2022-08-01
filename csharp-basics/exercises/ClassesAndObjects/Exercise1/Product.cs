using System;
using System.Collections.Generic;

namespace Exercise1
{
    public class Product
    { 
        public static readonly List<Product> ProductList = new List<Product>();
        private readonly string _name;
        private double _price;
        private int _amount;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            _price = priceAtStart;
            _amount = amountAtStart;
            ProductList.Add(this);
        }
        
        public override string ToString()
        {
            return $"{_name}, price {_price} EUR, amount {_amount} units";
        }

        public void UpdatePrice(double newPrice)
        {
            _price = newPrice;
        }

        public void UpdateAmount(int newAmount)
        {
            _amount = newAmount;
        }
    }
}