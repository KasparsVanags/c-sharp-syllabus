using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var soundList = new List<ISound>
            {
                new Firework(),
                new Parrot(),
                new Radio(),
                new Parrot(),
                new Parrot(),
                new Firework(),
                new Firework(),
                new Radio(),
                new Radio(),
            };
            
            soundList.ForEach(x => x.PlaySound());
            Console.ReadKey();
        }
    }
}