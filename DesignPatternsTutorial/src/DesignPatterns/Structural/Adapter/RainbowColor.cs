using DesignPatternsTutorial.src.DesignPatterns.Structural.Adapter.Package;

namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Adapter
{
    // Uses Composition, could also use Inheritance
    public class RainbowColor : Color
    {
        private Rainbow _rainbow;

        public RainbowColor(Rainbow rainbow)
        {
            _rainbow = rainbow;
        }
        public void Apply(Video video)
        {
            _rainbow.Setup();
            _rainbow.Update(video);
        }
    }

    // Uses Inheritance, less flexible as can only inherit from one class.
    public class RainbowColorInheritance : Rainbow, Color
    {
        public void Apply(Video video)
        {
            Setup();
            Update(video);
        }
    }
}