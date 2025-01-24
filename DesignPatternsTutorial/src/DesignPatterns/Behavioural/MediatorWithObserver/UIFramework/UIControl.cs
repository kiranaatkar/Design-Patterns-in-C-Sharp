namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.MediatorWithObserver.UIFramework
{
    // Subject class from observer pattern
    public class UIControl
    {
        private List<EventHandler> _eventHandlers = new List<EventHandler>();
        public void Attach(EventHandler eventHandler)
        {
            _eventHandlers.Add(eventHandler);
        }
        public void Detach(EventHandler eventHandler)
        {
            _eventHandlers.Remove(eventHandler);
        }
        public void Notify()
        {
            foreach (var eventHandler in _eventHandlers)
            {
                eventHandler();
            }
        }
    }
}