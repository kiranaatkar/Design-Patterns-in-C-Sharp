namespace DesignPatternsTutorial.src.DesignPatterns.Creational.AbstractFactory.UIWindows
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows Button");
        }
    }
}