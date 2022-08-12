namespace DragRace
{
    public interface ICar
    {
        int CurrentSpeed { get; }
        
        void SpeedUp();
       
        void SlowDown();

        void StartEngine();

        string ToString();
    }
}