using System;

namespace GetTheCentury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.WriteLine("Input a year 1000 - 2100: ");
                string yearInput = Console.ReadLine();
                Console.WriteLine("Year " + yearInput + " is in the " + Century(yearInput) + " century");
            }

            string Century(string year)
            {
                var centuryDigits = "";
                if (year[2] == '0' && year[3] == '0')
                {
                    centuryDigits = year.Substring(0, 2);
                }
                else
                {
                    centuryDigits += year[0];
                    var secondCenturyDigit = char.GetNumericValue(year[1]);
                    centuryDigits += secondCenturyDigit + 1;
                }

                if (centuryDigits[0] != '1' && centuryDigits[1] == '1')
                {
                    return centuryDigits + "st";
                }
                
                return centuryDigits + "th";
            }
        }
    }
}
