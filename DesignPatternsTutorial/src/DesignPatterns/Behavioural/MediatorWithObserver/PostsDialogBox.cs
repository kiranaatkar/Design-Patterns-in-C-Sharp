using DesignPatternsTutorial.src.DesignPatterns.Behavioural.MediatorWithObserver.UIFramework;

namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.MediatorWithObserver
{
    // Mediator - containing all the logic for how UI COMPONENTS SHOULD INTERACT
    // Observer - recieves notification when a UI component changes
    public class PostsDialogBox
    {
        private ListBox _listBox;
        private TextBox _textBox;
        private Button _button;

        public PostsDialogBox()
        {
            _listBox = new ListBox();
            _textBox = new TextBox();
            _button = new Button();

            _listBox.Attach(PostSelected);
            _textBox.Attach(TitleChanged);
        }     

        public void SimulateUserInteraction()
        {
            _listBox.SetSelection("Post 2");
            _textBox.SetText("");
            Console.WriteLine("TextBox: " + _textBox.GetText());
            Console.WriteLine("Button: " + _button.GetIsEnabled());
        }

        private void PostSelected()
        {
            _textBox.SetText(_listBox.GetSelection());
             _button.SetIsEnabled(true);
        }

        private void TitleChanged()
        {
            var content = _textBox.GetText();
            var isEmpty = string.IsNullOrEmpty(content);
            _button.SetIsEnabled(!isEmpty);
        }   
    }
}