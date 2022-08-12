namespace DragRace
{
    public class Lexus : Car, IBoost
    {
        public Lexus(int topSpeed, int accelerationModifier) : base(topSpeed, accelerationModifier)
        {
        }

        public void UseNitrousOxideEngine() 
        {
            CurrentSpeed += (TopSpeed - CurrentSpeed) / 15 * AccelerationModifier;
        }
    }
}