namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Bridge
{
    public abstract class RadioAndTvRemote : Remote
    {
        public abstract void ControlTv();
        public abstract void ControlRadio();
    }
}