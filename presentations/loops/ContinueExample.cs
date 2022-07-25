using System;

namespace ContinueExample
{
    class Program
    {
        private static void Main(string[] args)
        {
            const string searchMe = "peter piper picked a " + "peck of pickled peppers";
            var max = searchMe.Length;
            var numPs = 0;

            for (var i = 0; i < max; i++)
            {
                var searchMeArray = searchMe.ToCharArray();
                if (searchMeArray[i] != 'p') {
                    continue;
                }
                numPs++;
            }
            Console.WriteLine("Found " + numPs + " p's in the string.");
        }
    }
}