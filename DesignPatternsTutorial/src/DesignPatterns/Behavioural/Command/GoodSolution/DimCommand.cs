namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Command.GoodSolution
{
    public class DimCommand : ICommand
    {
        private Light _light;

        public DimCommand(Light light)
        {
            this._light = light;
        }

        public void Execute()
        {
            _light.Dim();
        }
    }
}