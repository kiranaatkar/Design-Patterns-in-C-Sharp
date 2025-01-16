namespace DesignPatternsTutorial.src.SOLID.O
{
    // every time we add a new shape to shapeType we have to MODIFY (no no) this class.
    // This violates the open/closed principle.
    // Instead, we can create a new class for each shape that inherits from Shape and implements the area calculation itself.
    // public class Shape
    // {
        
    //     public ShapeType Type { get; set; }
    //     public double Radius { get; set; }
    //     public double Width { get; set; }
    //     public double Length { get; set; }

    //     public double CalculateArea()
    //     {
    //         switch(Type)
    //         {
    //             case ShapeType.Circle:
    //                 return Math.PI * Math.Pow(Radius, 2);
    //             case ShapeType.Rectangle:
    //                 return Width * Length;
    //             default:
    //                 throw new InvalidOperationException("Invalid shape type");
    //         }
    //     }
    // }
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }
}