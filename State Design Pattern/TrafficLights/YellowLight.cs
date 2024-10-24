using System;

namespace State_Design_Pattern.TrafficLights
{
    public class YellowLight : ITrafficLightState
    {
        public void ChangeLight(TrafficLight trafficLight)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Traffic Light is Yellow. Caution!");
            trafficLight.SetState(new ReedLight());
        }
    }
}
