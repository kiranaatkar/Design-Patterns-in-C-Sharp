namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Momento
{
    // Caretaker class
    public class History
    {
        private List<EditorState> _states = new List<EditorState>();
        private Editor _editor;

        public History(Editor editor)
        {
            _editor = editor;
        }

        public void BackUp()
        {
            _states.Add(_editor.CreateState());
        }

        public void Undo()
        {
            if (_states.Count == 0) return;
            EditorState lastState = _states.Last();
            _editor.Restore(lastState);
            _states.Remove(lastState);
        }

        public void ShowHistory()
        {
            Console.WriteLine("History:");
            foreach (var state in _states)
            {
                Console.WriteLine($"Title: {state.GetTitle()}, Content: {state.GetContent()}, Created At: {state.GetCreatedAt()}");
            }
        }
    }
}