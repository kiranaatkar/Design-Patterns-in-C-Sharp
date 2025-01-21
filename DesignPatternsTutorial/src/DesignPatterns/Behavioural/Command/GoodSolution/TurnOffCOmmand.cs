namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Command.GoodSolution
{
    public class TurnOffCOmmand : ICommand
    {
        private Light _light;

        public TurnOffCOmmand(Light light)
        {
            this._light = light;
        }
        
        public void Execute()
        {
            _light.TurnOff();
        }
    }
}