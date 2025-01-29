namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Prototype
{
    public class ShapeActions
    {
        public Shape Duplicate(Shape shape)
        {
            Console.WriteLine("Duplicating shape...");
            Shape newShape = shape.Duplicate();
            return newShape;
        }
    }
}