namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Strategy.GoodSolution
{
    public class CompressorMp4 : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing using MP4");
        }
    }
}