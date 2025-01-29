namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Decorator.Good
{
    public abstract class DataDecorator : Data
    {
        protected Data _data; // wrapee - encryptedDasta and compressedData need access to this - hence protected not private
        
        public DataDecorator(Data data)
        {
            _data = data;
        }

        public abstract void Save(string data);
    }
}