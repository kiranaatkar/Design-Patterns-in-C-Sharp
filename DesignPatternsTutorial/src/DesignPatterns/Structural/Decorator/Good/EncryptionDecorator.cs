namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Decorator.Good
{
    public class EncryptionDecorator : DataDecorator
    {
        public EncryptionDecorator(Data data) : base(data)
        {
        }

        public override void Save(string data)
        {
            var encrypted = Encrypt(data);
            base._data.Save(encrypted);
        }

        public string Encrypt(string data)
        {
            return "hsdjksdfnauiosgiauergvaerig";
        }
    }
}