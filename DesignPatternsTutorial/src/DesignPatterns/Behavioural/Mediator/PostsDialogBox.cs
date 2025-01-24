namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Mediator
{
    public class PostsDialogBox : DialogBox
    {
        // fields for all ui components
        private ListBox _listBox;
        private TextBox _textBox;
        private Button _button;
        public PostsDialogBox()
        {
            _listBox = new ListBox(this);
            _textBox = new TextBox(this);
            _button = new Button(this);
            _button.SetIsEnabled(false);
        }

        public void SimulateUserInteraction()
        {
            _listBox.SetSelection("Post 2");
            _textBox.SetText("");
            Console.WriteLine("TextBox: " + _textBox.GetText());
            Console.WriteLine("Button: " + _button.GetIsEnabled());
        }
        public override void Changed(UIControl uiControl)
        {
            if (uiControl == _listBox)
            {
                HandlePostChanged();
            }
            else if (uiControl == _textBox)
            {
                HandleTitleChanged();
            }
        }

        private void HandlePostChanged()
        {
            _textBox.SetText(_listBox.GetSelection());
             _button.SetIsEnabled(true);
        }

        private void HandleTitleChanged()
        {
            var content = _textBox.GetText();
            var isEmpty = string.IsNullOrEmpty(content);
            _button.SetIsEnabled(!isEmpty);
        }
    }
}