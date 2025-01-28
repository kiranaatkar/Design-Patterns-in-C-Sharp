namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Bridge
{
    public class LGRadioAndTvRemote : RadioAndTvRemote
    {
        public override void ControlRadio()
        {
            System.Console.WriteLine("Controlling LG radio");
        }

        public override void ControlTv()
        {
            System.Console.WriteLine("Controlling LG TV");
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