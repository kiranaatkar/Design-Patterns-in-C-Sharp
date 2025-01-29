namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Prototype
{
    public class Rectangle : Shape
    {
        public int width { get; set; } = 10;
        public int height { get; set; } = 5;
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }

        public Shape Duplicate()
        {
            Rectangle newRectangle = new Rectangle();
            newRectangle.height = this.height;
            newRectangle.width = this.width;
            return newRectangle;
        }
    }
}