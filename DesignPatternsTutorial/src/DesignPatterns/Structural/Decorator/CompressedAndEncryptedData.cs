namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Decorator
{
    public class CompressedAndEncryptedData : CloudData
    {
        public CompressedAndEncryptedData(string url) : base(url)
        {
        }

        public override void Save(string data)
        {
            var compressed = new CompressedData(_url).Compress(data);
            var encrypted = new EncryptedData(_url).Encrypt(compressed);
            base.Save(encrypted);
        }
    }
}