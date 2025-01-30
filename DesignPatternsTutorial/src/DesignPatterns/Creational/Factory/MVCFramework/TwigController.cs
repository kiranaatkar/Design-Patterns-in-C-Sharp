namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Factory.MVCFramework
{
    public class TwigController : Controller
    {
        protected override ViewEngine CreateViewEngine()
        {
            return new TwigViewEngine();
        }
    }
}