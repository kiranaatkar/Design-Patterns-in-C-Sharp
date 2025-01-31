namespace DesignPatternsTutorial.src.DesignPatterns.Creational.AbstractFactory.UIWindows
{
    public class WindowsCheckBox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows Checkbox");
        }
    }
}