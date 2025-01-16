namespace DesignPatternsTutorial.src.SOLID.I
{
    public class Circle : IShape
    {

        public double Radius { get; set; }
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double Volume()
        {
            throw new NotImplementedException("Circles are 2D shapes and do not have volume");
        }
    }
}