namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Adapter
{
    public class Midnight : Color
    {
        public void Apply(Video video)
        {
            Console.WriteLine("Applying midnight filter to video");
        }
    }
}