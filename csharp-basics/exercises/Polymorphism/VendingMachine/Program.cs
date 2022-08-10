using System;

namespace VendingMachine
{
    internal class Program
    {
        private static readonly VendingMachine Vendinator9000 = new ("Vendinator9000", 10);

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine($"Your brand new {Vendinator9000.Products.Length} slot vending machine is ready.");
            Console.WriteLine("1 - prefill the first 5 slots, 2 - prefill all 10 slots, 3 - do everything manually");
            var selection = GetSelection(1, 3);
            if (selection is 1 or 2)
            {
                Vendinator9000.AddProduct("Coca-Cola", new Money(0, 70), 5);
                Vendinator9000.AddProduct("Sprite", new Money(0, 80), 4);
                Vendinator9000.AddProduct("Fanta", new Money(0, 60), 3);
                Vendinator9000.AddProduct("Pepsi", new Money(0, 70), 2);
                Vendinator9000.AddProduct("Coca-Cola VIP edition", new Money(5, 0), 1);
            }
            if (selection == 2)
            {
                Vendinator9000.AddProduct("Kvass", new Money(0, 50), 5);
                Vendinator9000.AddProduct("Dr Pepper", new Money(0, 60), 3);
                Vendinator9000.AddProduct("Mountain Dew", new Money(0, 70), 2);
                Vendinator9000.AddProduct("Diet Coke", new Money(0, 80), 4);
                Vendinator9000.AddProduct("Diet Pepsi", new Money(0, 80), 1);
            }

            Console.WriteLine(Vendinator9000.GetAllProducts());
            Console.WriteLine("Setup complete, press any key to start");
            Console.ReadKey();
            Console.Clear();
            
            var waitingForInput = true;
            while (waitingForInput)
            {
                ShowMainMenu();
            }
        }

        static void ShowMainMenu()
        {
            Console.WriteLine("Available products:");
            Console.WriteLine(Vendinator9000.GetAvailableProducts());
            Console.WriteLine($"Balance: {Vendinator9000.Amount}");
            Console.WriteLine("1 - insert coin, 2 - buy, 3 - return coins\n" +
                              "4 - add a product(employee), 5 - update a slot(employee)");
            var selection = GetSelection(1, 5);
            Console.Clear();
            switch (selection)
            {
                case 1:
                    CoinMenu();
                    break;
                case 2:
                    PurchaseMenu();
                    break;
                case 3:
                    Vendinator9000.ReturnMoney();
                    break;
                case 4:
                    AddProductMenu();
                    break;
                case 5:
                    UpdateProductMenu();
                    break;
            }
        }

        static void CoinMenu()
        {
            Console.WriteLine($"Balance: {Vendinator9000.Amount}");
            Console.WriteLine("Enter x,xx to insert a coin");
            Console.WriteLine($"Accepted coins - {string.Join(" | ", Vendinator9000.AcceptedMoney)}");
            var coin = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
            Console.Clear();
            Vendinator9000.InsertCoin(new Money(coin[0], coin[1]));
        }

        static void PurchaseMenu()
        {
            Console.WriteLine(Vendinator9000.GetAvailableProducts());
            Console.WriteLine($"Balance: {Vendinator9000.Amount}");
            Console.WriteLine("Enter product number:");
            var selection = int.Parse(Console.ReadLine());
            Console.Clear();
            Vendinator9000.BuyProduct(selection);
        }

        static void AddProductMenu()
        {
            Console.Clear();
            Console.WriteLine("Slot status:");
            Console.WriteLine(Vendinator9000.GetAllProducts());
            if (!Vendinator9000.HasFreeSlots())
            {
                Console.WriteLine("No free, unlabeled slots.");
                Console.WriteLine("1 - return to main menu, 2 - update a slot");
                var selection = GetSelection(1, 2);
                Console.Clear();
                if (selection == 1)
                {
                    ShowMainMenu();
                    return;
                }

                UpdateProductMenu();
            }
            
            Console.WriteLine("Enter product name, price(x,xx) and count separated by space");
            var productInfo = Console.ReadLine().Split(" ");
            var name = productInfo[0];
            var priceArr = Array.ConvertAll(productInfo[1].Split(','), int.Parse);
            var price = new Money(priceArr[0], priceArr[1]);
            var count = int.Parse(productInfo[2]);
            Console.Clear();
            Vendinator9000.AddProduct(name, price, count);
        }

        static void UpdateProductMenu()
        {
            Console.WriteLine(Vendinator9000.GetAllProducts());
            Console.WriteLine($"Enter 1 - {Vendinator9000.Products.Length} to select a product");
            var productNumber = GetSelection(1, Vendinator9000.Products.Length);
            Console.Clear();
            Console.WriteLine($"Selected {Vendinator9000.Products[productNumber - 1]}");
            Console.WriteLine("1 - update name, 2 - update price, 3 - update count, 4 - replace");
            var selection = GetSelection(1, 4);
            switch (selection)
            {
                case 1:
                    Console.WriteLine("Enter the new name:");
                    Vendinator9000.UpdateProduct(productNumber, Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Enter the new price(x,xx)");
                    var splitPrice = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
                    var newPrice = new Money(splitPrice[0], splitPrice[1]);
                    Vendinator9000.UpdateProduct(productNumber, newPrice);
                    break;
                case 3:
                    Console.WriteLine("Enter the new count:");
                    Vendinator9000.UpdateProduct(productNumber, int.Parse(Console.ReadLine()));
                    break;
                case 4:
                    Console.WriteLine("Enter name, price(x,xx) and count separated by space");
                    var productInfo = Console.ReadLine().Split(" ");
                    var name = productInfo[0];
                    var priceArr = Array.ConvertAll(productInfo[1].Split(','), int.Parse);
                    var price = new Money(priceArr[0], priceArr[1]);
                    var count = int.Parse(productInfo[2]);
                    Vendinator9000.UpdateProduct(productNumber, name, price, count);
                    break;
            }
            
            Console.Clear();
        }
        
        static int GetSelection(int min, int max)
        {
            if (int.TryParse(Console.ReadLine(), out var input) && input >= min && input <= max)
            {
                return input;
            }
            
            Console.WriteLine("Invalid selection, try gain:");
            input = GetSelection(min, max);
            return input;
        }
    }
}
