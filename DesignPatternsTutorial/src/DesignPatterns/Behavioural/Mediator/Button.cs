namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Mediator
{
    public class Button : UIControl
    {
        private bool _isEnabled = false;
        public Button(DialogBox owner) : base(owner)
        {
        }

        public bool GetIsEnabled()
        {
            return _isEnabled;
        }

        public void SetIsEnabled(bool isEnabled)
        {
            _isEnabled = isEnabled;
            _owner.Changed(this);
        }
    }
}