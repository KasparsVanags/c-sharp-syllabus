using System;

namespace BreakExample
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] arrayOfInts = {32, 87, 3, 589, 12};
            const int searchFor = 12;

            int i;
            var foundIt = false;

            for (i = 0; i < arrayOfInts.Length; i++) {
                if (arrayOfInts[i] == searchFor) {
                    foundIt = true;
                    break;
                }
            }

            if (foundIt) {
                Console.WriteLine("Found " + searchFor + " at index " + i);
            } else {
                Console.WriteLine(searchFor + " not in the array");
            }
        }
    }
}