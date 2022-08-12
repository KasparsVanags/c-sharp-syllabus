using System;
using System.Collections.Generic;

namespace DragRace
{
    public abstract class Car : ICar
    {
        public int CurrentSpeed { get; set; }
        protected readonly int AccelerationModifier;
        protected readonly int TopSpeed;
        public static readonly List<Car> CarList = new List<Car>();

        public Car(int topSpeed, int accelerationModifier)
        {
            TopSpeed = topSpeed;
            AccelerationModifier = accelerationModifier;
            CurrentSpeed = 0;
            CarList.Add(this);
        }

        public void SpeedUp() 
        {
            CurrentSpeed += (TopSpeed - CurrentSpeed) / 30 * AccelerationModifier;
        }
        
        public void SlowDown()
        {
            CurrentSpeed = 0;
        }

        public virtual void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
        
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}