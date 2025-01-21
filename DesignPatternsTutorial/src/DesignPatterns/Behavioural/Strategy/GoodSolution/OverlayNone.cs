namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Strategy.GoodSolution
{
    public class OverlayNone : IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying no overlay");
        }
    }
}