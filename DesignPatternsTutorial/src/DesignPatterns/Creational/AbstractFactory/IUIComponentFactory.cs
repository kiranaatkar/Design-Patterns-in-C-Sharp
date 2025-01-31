namespace DesignPatternsTutorial.src.DesignPatterns.Creational.AbstractFactory
{
    public interface IUIComponentFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}