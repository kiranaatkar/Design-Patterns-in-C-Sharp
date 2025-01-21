namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Command
{
    public class RemoteControl
    {
        // Invoker
        private Light _light;

        public RemoteControl(Light light)
        {
            this._light = light;
        }

        public void PressButton(bool turnOn)
        {
            if (turnOn)
                _light.TurnOn();
            else
                _light.TurnOff();
        }
    }
}