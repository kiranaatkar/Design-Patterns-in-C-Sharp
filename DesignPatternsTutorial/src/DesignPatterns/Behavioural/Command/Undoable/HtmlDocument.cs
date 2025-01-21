namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Command.Undoable
{
    public class HtmlDocument
    {
        public string Content { get; set; }
        public void MakeItalic()
        {
            Content = "<i>" + Content + "</i>";
        }
    }
}