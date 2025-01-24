namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.MediatorWithObserver.UIFramework
{
    public class Button : UIControl
    {
        private bool _isEnabled = false;

        public bool GetIsEnabled()
        {
            return _isEnabled;
        }

        public void SetIsEnabled(bool isEnabled)
        {
            _isEnabled = isEnabled;
            Notify();
        }
    }
}