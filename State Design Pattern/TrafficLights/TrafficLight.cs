namespace State_Design_Pattern.TrafficLights
{
    public class TrafficLight
    {
        private ITrafficLightState _state;

        public TrafficLight()
        {
            // Initial state
            _state = new ReedLight();
        }

        public void SetState(ITrafficLightState state)
        {
            _state = state;
        }

        public void Change()
        {
            _state.ChangeLight(this);
        }
    }
}
