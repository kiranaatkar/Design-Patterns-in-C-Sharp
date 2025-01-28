namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Bridge.Good
{
    public class AdvancedRemote : RemoteControl
    {
        public AdvancedRemote(Device device) : base(device)
        {
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine("Setting channel to " + channel);
        }
    }
}