namespace DesignPatternsTutorial.src.SOLID.O
{
    public class Rectangle : Shape
    {
        private double width;
        private double length;

        public override double CalculateArea()
        {
            return width * length;
        }
    }
}