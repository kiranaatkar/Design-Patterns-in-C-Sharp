namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Factory.MVCFramework
{
    public class Controller
    {
        public void Render(string fileName, Dictionary<string, object> data)
        {
            var engine = CreateViewEngine();
            var html = engine.Render(fileName, data);
            Console.WriteLine(html);
        }
        protected virtual ViewEngine CreateViewEngine()
        {
            return new BladeViewEngine();
        }
    }
}