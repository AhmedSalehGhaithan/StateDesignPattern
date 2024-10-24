using System;

namespace State_Design_Pattern.TrafficLights
{
    public class ReedLight : ITrafficLightState
    {
        public void ChangeLight(TrafficLight trafficLight)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Traffic Light is Red. Stop!");
            trafficLight.SetState(new GreenLight());
        }
    }
}
