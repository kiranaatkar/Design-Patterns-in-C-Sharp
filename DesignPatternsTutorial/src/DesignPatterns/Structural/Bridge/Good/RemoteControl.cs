namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Bridge.Good
{
    public class RemoteControl
    {
        private Device device;
        public RemoteControl(Device device)
        {
            this.device = device;
        }
        public void TurnOn()
        {
            device.TurnOn();
        }
        public void TurnOff()
        {
            device.TurnOff();
        }
    }
}