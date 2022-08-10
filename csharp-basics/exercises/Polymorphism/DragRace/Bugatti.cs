using System;

namespace DragRace
{
    public class Bugatti : Car
    {
        public Bugatti(int topSpeed, int accelerationModifier) : base(topSpeed, accelerationModifier)
        {
        }

        public override void StartEngine() 
        {
            Console.WriteLine("RRRRRRR.....");
        }
    }
}