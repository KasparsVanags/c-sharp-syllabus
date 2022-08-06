using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "./flights.txt";
        private static void Main(string[] args)
        {
            var flightPaths = new Dictionary<string, List<string>>();
            var readText = File.ReadAllLines(Path).Where(x => !string.IsNullOrWhiteSpace(x));
            foreach (var flightPath in readText)
            {
                var splitPath = flightPath.Split(new[] { " -> " }, StringSplitOptions.None);
                try
                {
                    flightPaths.Add(splitPath[0], new List<string> { splitPath[1] });
                }
                catch(ArgumentException)
                {
                    flightPaths[splitPath[0]].Add(splitPath[1]);
                }
            }
            
            Console.WriteLine(@"                                       |
                                       |
                                       |
                                     .-'-.
                                    ' ___ '
                          ---------'  .-.  '---------
          _________________________'  '-'  '_________________________
           ''''''-|---|--/    \==][^',_m_,'^][==/    \--|---|-''''''
                         \    /  ||/   H   \||  \    /
                          '--'   OO   O|O   OO   '--'
                           Welcome to flight planner");
            Console.WriteLine("1 - list cities, 0 - exit");
            if (GetSelection(0, 1) == 0)
            {
                Environment.Exit(0);
            }
            
            var waitingForInput = true;
            while (waitingForInput)
            {
                for (var i = 0; i < flightPaths.Count; i++)
                {
                    Console.WriteLine($"{i} - {flightPaths.ElementAt(i).Key}");
                }
                
                Console.WriteLine($"Press 0 - {flightPaths.Count - 1} to select city of departure");
                var flightPlan = new List<string> {flightPaths.ElementAt(GetSelection(0, flightPaths.Count)).Key};
                var currentCity = flightPlan[0];
                var isPlanningDone = false;
                while (!isPlanningDone)
                {
                    Console.WriteLine("Current flight plan:");
                    Console.WriteLine(string.Join(" -> ", flightPlan));
                    var lastDestinationIndex = flightPaths[currentCity].Count - 1;
                    Console.WriteLine($"Select your destination or press");
                    for (var i = 0; i < lastDestinationIndex; i++)
                    {
                        Console.WriteLine($"{i} - {flightPaths[currentCity][i]}");
                    }

                    flightPlan.Add(flightPaths[currentCity][GetSelection(0, lastDestinationIndex)]);
                    var lastCityAdded = flightPlan[flightPlan.Count - 1];
                    currentCity = lastCityAdded;
                    if (flightPlan[0] == lastCityAdded)
                    {
                        isPlanningDone = true;
                    }
                }
                
                Console.WriteLine("Chosen flight plan:");
                Console.WriteLine(string.Join(" -> ", flightPlan));
                Console.WriteLine("0 - exit, 1 - create a new plan");
                if (GetSelection(0, 1) == 0)
                {
                    Environment.Exit(0);
                }
            }
        }
        
        static int GetSelection(int min, int max)
        {
            if (int.TryParse(Console.ReadLine(), out var input) && input >= min && input <= max)
            {
                return input;
            }
                
            Console.WriteLine("Invalid selection, try gain:");
            input = GetSelection(min, max);
            return input;
        }
    }
}
