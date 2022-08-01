using System;

namespace Exercise1
{
    internal class Program
    {
        private static int selection = 0;
        public static void Main(string[] args)
        {
            var logitechMouse = new Product("Logitech mouse", 70.00, 14);
            var iPhone5S = new Product("iPhone 5s", 999.99, 3);
            var epsonEbu05 = new Product("Epson EB-U05", 440.46, 1);
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.WriteLine("Current products:");
                for (var i = 0; i < Product.ProductList.Count; i++)
                {
                    Console.Write(i + " - ");
                    Console.WriteLine(Product.ProductList[i]);
                }
                
                Console.WriteLine($"Enter 0 - {Product.ProductList.Count - 1} to select a product");
                SelectProduct((int)GetInput());
                Console.WriteLine("1 - change price, 2 - change amount");
                if (GetInput() == 1)
                {
                     UpdatePrice();
                }
                else
                {
                    UpdateAmount();
                }
            }
        }

        static double GetInput()
        {
            return double.Parse(Console.ReadLine());
        }

        static void SelectProduct(int index)
        {
            Console.Write("Selected:\n" + index + " - ");
            Console.WriteLine(Product.ProductList[index]);
            selection = index;
        }

        static void UpdatePrice()
        {
            Console.WriteLine("Enter the new price:");
            Product.ProductList[selection].UpdatePrice(GetInput());
            Console.WriteLine("Price updated!");
        }

        static void UpdateAmount()
        {
            Console.WriteLine("Enter the new amount:");
            Product.ProductList[selection].UpdateAmount((int)GetInput());
            Console.WriteLine("Quantity updated!");
        }
    }
}