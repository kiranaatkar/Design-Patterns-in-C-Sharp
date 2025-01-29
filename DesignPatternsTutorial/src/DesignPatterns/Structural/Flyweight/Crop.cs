namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Flyweight
{
    public class Crop
    {
        private int _x;
        private int _y;
        private CropIcon _cropIcon;

        public Crop(int x, int y, CropIcon cropIcon)
        {
            _x = x;
            _y = y;
            _cropIcon = cropIcon;
        }

        public void Render()
        {
            Console.WriteLine($"Rendering crop {_cropIcon.GetType} at ({_x}, {_y})");
        }
    }
}