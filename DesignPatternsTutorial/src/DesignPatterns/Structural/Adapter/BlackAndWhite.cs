namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Adapter
{
    public class BlackAndWhite : Color
    {
        public void Apply(Video video)
        {
            Console.WriteLine("Applying black and white filter to video");
        }
    }
}