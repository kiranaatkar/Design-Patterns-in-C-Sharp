namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Command.GoodSolution
{
    public class TurnOnCommand : ICommand
    {
        private Light _light;

        public TurnOnCommand(Light light)
        {
            this._light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }
}