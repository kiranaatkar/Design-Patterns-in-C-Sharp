namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Strategy.GoodSolution
{
    public class CompressorMOV : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing using MOV");
        }
    }
}