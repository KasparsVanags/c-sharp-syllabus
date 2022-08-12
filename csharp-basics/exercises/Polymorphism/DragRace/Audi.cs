namespace DragRace
{
    public class Audi : Car, IBoost
    {
        public Audi(int topSpeed, int accelerationModifier) : base(topSpeed, accelerationModifier)
        {
        }

        public void UseNitrousOxideEngine() 
        {
            CurrentSpeed += (TopSpeed - CurrentSpeed) / 15 * AccelerationModifier;
        }
    }
}