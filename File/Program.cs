using File;
using System;

using System;
using System.Threading;

enum TrafficLight
{
    Red,
    Yellow,
    Green
}

class Program
{
    static void Main(string[] args)
    {
        
        int duration = 2000;

         
        {
            foreach (TrafficLight color in Enum.GetValues(typeof(TrafficLight)))
            {
                Console.WriteLine("Current color: " + color);
                Thread.Sleep(duration);
                //Console.Clear();
            }
        }
    }
}