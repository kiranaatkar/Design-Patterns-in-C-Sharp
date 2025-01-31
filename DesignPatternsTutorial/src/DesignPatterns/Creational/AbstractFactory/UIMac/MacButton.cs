namespace DesignPatternsTutorial.src.DesignPatterns.Creational.AbstractFactory.UIMac
{
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mac Button");
        }
    }
}