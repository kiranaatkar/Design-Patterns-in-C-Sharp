namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Observer.GoodSolution
{
    public class DataSource : Subject
    {
        private List<int> _values = new List<int>();

        public List<int> GetValues()
        {
            return _values;
        }

        public void SetValues(List<int> values)
        {
            _values = values;
            NotifyObservers();
        }
    }
}