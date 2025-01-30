namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Factory.MVCFramework
{
    public interface ViewEngine
    {
        string Render(string fileName, Dictionary<string, object> data);
    }
}