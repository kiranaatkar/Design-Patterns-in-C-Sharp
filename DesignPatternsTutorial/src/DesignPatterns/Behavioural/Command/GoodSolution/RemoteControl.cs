namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Command.GoodSolution
{
    public class RemoteControl
    {
        private ICommand _command;

        public RemoteControl(ICommand command)
        {
            this._command = command;
        }

        public void SetCommand(ICommand command)
        {
            this._command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }
}