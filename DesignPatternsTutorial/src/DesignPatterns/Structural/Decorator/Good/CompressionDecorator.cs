namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Decorator.Good
{
    public class CompressionDecorator : DataDecorator
    {
        public CompressionDecorator(Data data) : base(data)
        {
        }

        public override void Save(string data)
        {
            Console.WriteLine("Compressing data");
            var compressed = Compress(data);
            base._data.Save(compressed);
        }

        public string Compress(string data)
        {
            return data.Substring(0, 5);
        }
    }
}