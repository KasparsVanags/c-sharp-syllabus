using System;
using System.Linq;
using System.Timers;

namespace DragRace
{
    internal class Program
    {
        private static Timer _raceTimer;
        private static int _timePassed = 0;
        private static int _accelerationTime = 10;
        private static readonly ICar Bugatti = new Bugatti(420, 3);
        private static readonly ICar Kamaz = new Kamaz(90, 1);
        private static readonly ICar Audi = new Audi(250 , 2);
        private static readonly ICar Bmw = new Bmw(250, 2);
        private static readonly ICar Lexus = new Lexus(240, 2);
        private static readonly ICar Tesla = new Tesla(322, 5);

        private static void Main(string[] args)
        {
            Console.WriteLine("Time: " + _timePassed);
            foreach (var car in Car.CarList)
            {
                Console.Write($"{car} - ");
                car.StartEngine();
            }
            
            Console.WriteLine("Press any key when ready");
            Console.ReadKey();
            _timePassed++;
            SetTimer();
            Console.ReadKey();
        }

        private static void Race()
        {
            Console.Clear();
            Console.WriteLine("Time: " + _timePassed);
            foreach (var car in Car.CarList)
            {
                var boost = "";
                if (_timePassed == 3 && car is IBoost boostedCar)
                {
                    boostedCar.UseNitrousOxideEngine();
                    boost = "BOOST";
                }
                else
                {
                    car.SpeedUp();
                }

                Console.WriteLine($"{car} - {car.CurrentSpeed} km/h {boost}");
            }

            _timePassed++;
            if (_timePassed > _accelerationTime)
            {
                _raceTimer.Stop();
                var winner = Car.CarList.OrderByDescending(x => x.CurrentSpeed).First();
                Console.WriteLine($"Winner - {winner}, speed - {winner.CurrentSpeed} km/h");
            }
        }
        
        private static void SetTimer()
        {
            _raceTimer = new Timer(1000);
            _raceTimer.Elapsed += OnTimedEvent;
            _raceTimer.Enabled = true;
        }
        
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Race();
        }
    }
}