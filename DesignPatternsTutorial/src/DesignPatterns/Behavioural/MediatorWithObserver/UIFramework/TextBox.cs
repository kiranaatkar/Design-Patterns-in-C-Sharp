namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.MediatorWithObserver.UIFramework
{
    public class TextBox : UIControl
    {
        private string _content = "";

        public string GetText()
        {
            return _content;
        }

        public void SetText(string content)
        {
            _content = content;
            Notify();
        }
    }
}