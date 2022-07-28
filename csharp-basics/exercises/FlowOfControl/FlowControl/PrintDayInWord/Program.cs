using System;

namespace PrintDayInWord
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var waitingForInput = true;
            while (waitingForInput)
            {
                Console.Write("Input a day number, starting at 0: ");
                if(int.TryParse(Console.ReadLine(), out int dayNumber))
                {
                    if (dayNumber >= 0 && dayNumber <= 6)
                    {
                        string day;
                        switch (dayNumber)
                        {
                            case 0:
                                day = "Monday";
                                break;
                            case 1:
                                day = "Tuesday";
                                break;
                            case 2:
                                day = "Wednesday";
                                break;
                            case 3:
                                day = "Thursday";
                                break;
                            case 4:
                                day = "Friday";
                                break;
                            case 5:
                                day = "Saturday";
                                break;
                            case 6:
                                day = "Sunday";
                                break;
                            default:
                                day = "Invalid value";
                                break;
                        }
                        
                        Console.WriteLine(day);
                        continue;
                    }
                }
                
                Console.WriteLine("Not a valid day");
            }
        }
    }
}