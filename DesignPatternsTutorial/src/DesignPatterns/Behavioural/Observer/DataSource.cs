namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Observer
{
    // violates SRP, O/C P and DIP
    public class DataSource
    {
        private List<int> _values = new List<int>();

        private List<Object> _dependants = new List<Object>();

        public List<int> GetValues()
        {
            return _values;
        }

        public void SetValues(List<int> values)
        {
            _values = values;
            NotifyDependants();
        }

        public void NotifyDependants()
        {
            foreach (var dependant in _dependants)
            {
                if (dependant is Spreadsheet2)
                {
                    ((Spreadsheet2)dependant).CalculateTotal(_values);
                }
                else if (dependant is BarChart)
                {
                    ((BarChart)dependant).Render(_values);
                }
            }
        }

        public void AddDependant(Object dependant)
        {
            _dependants.Add(dependant);
        }

        public void RemoveDependant(Object dependant)
        {
            _dependants.Remove(dependant);
        }
    }
}