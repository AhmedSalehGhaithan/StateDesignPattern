using System;

namespace State_Design_Pattern.TrafficLights
{
    public class GreenLight : ITrafficLightState
    {
        public void ChangeLight(TrafficLight trafficLight)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Traffic Light is Green. Go!");
            trafficLight.SetState(new YellowLight());
        }
    }
}
