namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Adapter.Package
{
    public class Rainbow
    {
        public void Setup()
        {
            Console.WriteLine("Rainbow filter being set u[p]");
        }

        public void Update(Video video)
        {
            Console.WriteLine("Rainbow filter being updated");
        }
    }
}