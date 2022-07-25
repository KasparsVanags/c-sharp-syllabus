using System;

namespace MakeSounds
{
    public class Firework: ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("whoosh-bang");
        }
    }
}