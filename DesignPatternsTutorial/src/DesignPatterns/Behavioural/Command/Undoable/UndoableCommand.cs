namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Command.Undoable
{
    public interface UndoableCommand : Command
    {
        void Unexecute();
    }
}