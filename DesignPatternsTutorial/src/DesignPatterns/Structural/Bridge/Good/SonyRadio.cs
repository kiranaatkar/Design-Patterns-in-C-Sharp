namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Bridge.Good
{
    public class SonyRadio : Device
    {
        public void SetChannel(int channel)
        {
            Console.WriteLine("Setting channel to " + channel);
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off Sony radio");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on Sony radio");
        }
    }
}