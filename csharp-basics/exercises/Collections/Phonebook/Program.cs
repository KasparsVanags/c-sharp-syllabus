using System;
using PhoneBook;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new PhoneDirectory();
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.WriteLine("PhoneBook currently contains:");
                foreach (var name in phoneBook.GetNames())
                {
                    Console.WriteLine(name);
                }
                
                Console.WriteLine(new string('=', 72));
                Console.WriteLine("1 - get number, 2 - add a number, 3 - remove a number, 4 - edit a number");
                var input = GetSelection(1, 4);
                Console.WriteLine("Enter name: ");
                if (input == 1)
                {
                    var name = Console.ReadLine();
                    Console.WriteLine($"{name} - {phoneBook.GetNumber(name)}");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();

                }
                else if (input == 2)
                {
                    var name = Console.ReadLine();
                    Console.Write("Enter number: ");
                    phoneBook.PutNumber(name, Console.ReadLine());
                    Console.WriteLine("Number added");
                }
                else if (input == 3)
                {
                    phoneBook.DeleteNumber(Console.ReadLine());
                    Console.WriteLine("Number deleted");
                }
                else if (input == 4)
                {
                    var name = Console.ReadLine();
                    Console.WriteLine($"Current number - {phoneBook.GetNumber(name)}");
                    Console.WriteLine("Enter the new number:");
                    phoneBook.EditNumber(name, Console.ReadLine());
                    Console.WriteLine("Number edited");
                }
            }
            
            int GetSelection(int min, int max)
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
}
