using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] carArray = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            var carList = carArray.ToList();
            Console.WriteLine("List: " + string.Join(", ", carList));
            var carHashSet = new HashSet<string>(carArray);
            Console.WriteLine("HashSet: " + string.Join(", ", carHashSet));
            Console.WriteLine("Dictionary: ");
            var carDictionary = new Dictionary<string, string>();
            foreach (var brand in carArray)
            {
                var country = "";
                switch (brand)
                {
                    case "Audi": case "BMW": case "Mercedes": case "VolksWagen":
                        country = "Germany";
                        break;
                    case "Honda":
                        country = "Japan";
                        break;
                    case "Tesla":
                        country = "USA";
                        break;
                }

                try
                {
                    carDictionary.Add(brand, country);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Can't add more than 1 " + brand);
                }
            }
            
            foreach (var entry in carDictionary)
            {
                Console.WriteLine(entry);
            }

            Console.ReadKey();
        }
    }
}