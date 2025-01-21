namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Command.Undoable
{
    public class UndoCommand : Command
    {
        private CommandHistory _history;

        public UndoCommand(CommandHistory history)
        {
            _history = history;
        }

        public void Execute()
        {
            if (_history.Size() > 0)
            {
                var lastCommand = _history.Pop();
                lastCommand.Unexecute();
            }
        }
    }
}