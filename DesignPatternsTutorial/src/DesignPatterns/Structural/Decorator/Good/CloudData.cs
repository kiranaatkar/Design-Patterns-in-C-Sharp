namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Decorator.Good
{
    public class CloudData : Data
    {
        protected string _url;

        public CloudData(string url)
        {
            _url = url;
        }

        public virtual void Save(string data)
        {
            Console.WriteLine($"Saving data {data} to {_url}");
        }
    }
}