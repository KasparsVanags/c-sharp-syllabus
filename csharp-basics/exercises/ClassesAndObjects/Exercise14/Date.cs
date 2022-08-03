using System;
using System.Globalization;

namespace Exercise14
{
    public static class Date
    {
        public static string WeekdayInDutch(int year, int month, int day)
        {
            var dutch = new CultureInfo("nl-NL");
            var date = new DateTime(year, month, day);
            return date.ToString("dddd", dutch);
        }
    }
}