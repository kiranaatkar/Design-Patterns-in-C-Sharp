namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Command.Undoable
{
    public class ItalicCommand : UndoableCommand
    {
        private HtmlDocument _doc;
        private string _prevContent = "";
        private CommandHistory _history;

        public ItalicCommand(HtmlDocument doc, CommandHistory history)
        {
            _doc = doc;
            _history = history;
        }
        public void Execute()
        {
            _prevContent = _doc.Content;
            _doc.MakeItalic();
            _history.Push(this);
        }

        public void Unexecute()
        {
            _doc.Content = _prevContent;
        }
    }
}