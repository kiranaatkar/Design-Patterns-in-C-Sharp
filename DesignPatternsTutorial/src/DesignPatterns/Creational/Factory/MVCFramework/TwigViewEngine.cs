
namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Factory.MVCFramework
{
    public class TwigViewEngine : ViewEngine
    {
        public string Render(string fileName, Dictionary<string, object> data)
        {
            return $"Twig View Engine {fileName}";
        }
    }
}