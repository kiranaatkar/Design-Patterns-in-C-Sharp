namespace DesignPatternsTutorial.src.SOLID.I
{
    public interface IShape
    {
         double Area();
         // 2D shapes don't have volume, so the client of this interface like a circle wont be able to implement this.
         // This will lead to useless methods being created, and violates the Interface segregation principle. 
         // Instead, we should segregate to IShape2D and IShape3D. IShape2D will have just area, and 3D will have both.
         double Volume();
    }
}