namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Bridge.Good
{
    public class LgRadio : Device
    {
        public void SetChannel(int channel)
        {
            Console.WriteLine("Setting channel to " + channel);
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off LG radio");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on LG radio");
        }
    }
}