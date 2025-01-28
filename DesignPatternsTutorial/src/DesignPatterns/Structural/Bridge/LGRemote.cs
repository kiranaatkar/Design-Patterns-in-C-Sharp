namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Bridge
{
    public class LGRemote : Remote
    {
        public override void TurnOn()
        {
            Console.WriteLine("Turning on LG TV");
        }
        public override void TurnOff()
        {
            Console.WriteLine("Turning off LG TV");
        }
        public override void VolumeUp()
        {
            Console.WriteLine("Increasing volume of LG TV");
        }
        public override void VolumeDown()
        {
            Console.WriteLine("Decreasing volume of LG TV");
        }

    }
}