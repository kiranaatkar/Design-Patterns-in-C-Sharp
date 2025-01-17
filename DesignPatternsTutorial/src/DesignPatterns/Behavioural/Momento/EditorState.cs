namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Momento
{
    // Memento class
    public class EditorState
    {
        private readonly string _title;
        private readonly string _content;

        // State metadata
        private readonly DateTime _createdAt;

        public EditorState(string title, string content)
        {
            _title = title;
            _content = content;
            _createdAt = DateTime.Now;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetContent()
        {
            return _content;
        }

        public DateTime GetCreatedAt()
        {
            return _createdAt;
        }
    }
}