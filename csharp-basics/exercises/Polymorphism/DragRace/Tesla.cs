using System;

namespace DragRace
{
    public class Tesla : Car
    {
        public Tesla(int topSpeed, int accelerationModifier) : base(topSpeed, accelerationModifier)
        {
        }

        public override void StartEngine() 
        {
            Console.WriteLine("*** silence ***");
        }
    }
}