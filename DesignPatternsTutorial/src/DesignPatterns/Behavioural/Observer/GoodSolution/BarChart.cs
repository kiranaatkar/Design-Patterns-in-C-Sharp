namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Observer.GoodSolution
{
    public class BarChart : Observer
    {
        private DataSource _dataSource;
        public BarChart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("making Bar Chart");
        }
    }
}