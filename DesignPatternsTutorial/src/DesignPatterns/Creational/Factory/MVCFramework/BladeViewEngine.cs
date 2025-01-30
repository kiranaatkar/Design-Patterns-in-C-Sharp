
namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Factory.MVCFramework
{
    public class BladeViewEngine : ViewEngine
    {
        public string Render(string fileName, Dictionary<string, object> data)
        {
            return $"Blade View Engine {fileName}";
        }
    }
}