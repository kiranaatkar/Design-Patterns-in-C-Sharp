namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Strategy.GoodSolution
{
    public class CompressorWEBM : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing using WEBM");
        }
    }
}