using DesignPatternsTutorial.src.DesignPatterns.Creational.AbstractFactory.UIMac;

namespace DesignPatternsTutorial.src.DesignPatterns.Creational.AbstractFactory
{
    public class MacComponentFactory : IUIComponentFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckBox();
        }
    }
}