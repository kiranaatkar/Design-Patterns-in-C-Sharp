namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Bridge
{
    public class AdvancedLGRemote : AdvancedRemote
    {
        public override void SetChannel(int channel)
        {
            System.Console.WriteLine($"Setting channel to {channel}");
        }

        public override void TurnOff()
        {
            System.Console.WriteLine("Turning off LG TV");
        }

        public override void TurnOn()
        {
            System.Console.WriteLine("Turning on LG TV");
        }

        public override void VolumeDown()
        {
            System.Console.WriteLine("Volume down on LG TV");
        }

        public override void VolumeUp()
        {
            System.Console.WriteLine("Volume up on LG TV");
        }
    }
}