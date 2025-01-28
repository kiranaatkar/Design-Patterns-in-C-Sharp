namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Bridge.Good
{
    public interface Device
    {
        public void TurnOn();
        public void TurnOff();
        public void SetChannel(int channel);
    }
}