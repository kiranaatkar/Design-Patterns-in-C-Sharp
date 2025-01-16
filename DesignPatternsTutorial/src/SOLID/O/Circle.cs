namespace DesignPatternsTutorial.src.SOLID.O
{
    public class Circle : Shape
    {
        private double radius;
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}