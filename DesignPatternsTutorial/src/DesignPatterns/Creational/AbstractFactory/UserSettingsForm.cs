using DesignPatternsTutorial.src.DesignPatterns.Creational.AbstractFactory.UIMac;
using DesignPatternsTutorial.src.DesignPatterns.Creational.AbstractFactory.UIWindows;

namespace DesignPatternsTutorial.src.DesignPatterns.Creational.AbstractFactory
{
    public class UserSettingsForm
    {
        public void Render(IUIComponentFactory uiComponentFactory)
        {
            // if (os == OperatingSystemType.Windows)
            // {
            //     new WindowsButton().Render();
            //     new WindowsCheckBox().Render();
            // }
            // else if (os == OperatingSystemType.Mac)
            // {
            //     new MacButton().Render();
            //     new MacCheckBox().Render();
            // }

            var button = uiComponentFactory.CreateButton();
            var checkbox = uiComponentFactory.CreateCheckbox();

            button.Render();
            checkbox.Render();
        }
    }
}