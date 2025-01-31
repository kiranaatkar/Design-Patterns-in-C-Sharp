using DesignPatternsTutorial.src.DesignPatterns.Creational.AbstractFactory.UIWindows;

namespace DesignPatternsTutorial.src.DesignPatterns.Creational.AbstractFactory
{
    public class WindowsComponentFactory : IUIComponentFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckBox();
        }
    }
}