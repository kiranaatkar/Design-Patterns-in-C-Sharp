namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Strategy.GoodSolution
{
    public class OverlayBlackAndWhite : IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying Black and White overlay");
        }
    }
}