namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Command.Undoable
{
    public class CommandHistory
    {
        private List<UndoableCommand> _commands = new List<UndoableCommand>();

        public void Push(UndoableCommand command)
        {
            _commands.Add(command);
        }

        public UndoableCommand Pop()
        {
            var last = _commands.Last();
            _commands.Remove(last);
            return last;
        }

        public int Size()
        {
            return _commands.Count;
        }
    }
}