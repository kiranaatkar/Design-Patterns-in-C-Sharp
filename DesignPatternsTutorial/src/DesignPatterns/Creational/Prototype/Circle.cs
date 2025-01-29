namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Prototype
{
    public class Circle : Shape
    {
        public int Radius { get; set; } = 5;
        public void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }

        public Shape Duplicate()
        {
            Circle newCircle = new Circle();
            newCircle.Radius = this.Radius;
            return newCircle;
        }
    }
}