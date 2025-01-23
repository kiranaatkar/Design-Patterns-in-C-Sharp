namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Observer.GoodSolution
{
    public class Subject
    {
        private List<Observer> _observers = new List<Observer>();
        public void AddObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}