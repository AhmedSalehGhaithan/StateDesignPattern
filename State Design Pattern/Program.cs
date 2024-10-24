using State_Design_Pattern.TrafficLights;
using System;
using System.Threading;

namespace State_Design_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();

            while (true) { 
                trafficLight.Change();
                Thread.Sleep(5000);
                Console.Clear();
            }
        }
    }
}
