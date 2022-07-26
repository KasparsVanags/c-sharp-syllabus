using System;

namespace Exercise6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var rand = new Random();
            int[] arr = new int[10];
            int[] copyArr = new int[10];
            const int maxNumber = 100;
            const int numToEnter = -7;
            
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(maxNumber);
            }
            
            Array.Copy(arr, copyArr, arr.Length);
            arr[arr.Length - 1] = numToEnter;
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(string.Join(" ", copyArr));
            Console.ReadKey();
        }
    }
}