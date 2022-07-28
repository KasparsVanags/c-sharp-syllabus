using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.WriteLine("Input an integer number less than ten billion: ");
                var input = Console.ReadLine();
                if (long.TryParse(input, out long number))
                {
                    if (number < 0)
                    {
                        number *= -1;
                    }
                    
                    var digitArray = number.ToString().ToCharArray();
                    if (number >= 10000000000)
                    {
                        Console.WriteLine("Number is greater or equals 10,000,000,000!");
                    }
                    else
                    {
                        Console.WriteLine("Number of digits in the number: " + digitArray.Length);
                    }
                }
                else
                {
                    Console.WriteLine("The number is not a long");
                }
            }
        }
    }
}
