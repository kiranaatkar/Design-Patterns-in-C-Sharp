namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Momento
{
    // Originator class
    public class Editor
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(Title, Content);
        }

        public void Restore(EditorState state)
        {
            Title = state.GetTitle();
            Content = state.GetContent();
            Console.WriteLine($"Restored state from: {state.GetCreatedAt()}");
        }
    }
}