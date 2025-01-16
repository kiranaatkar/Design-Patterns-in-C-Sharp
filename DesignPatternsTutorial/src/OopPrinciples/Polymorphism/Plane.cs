namespace DesignPatternsTutorial.src.OopPrinciples.Polymorphism
{
  public class Plane : Vehicle
  {
    public virtual void Start()
    {
      Console.WriteLine("Plane is starting.");
    }

    public virtual void Stop()
    {
      Console.WriteLine("Plane is stopping.");
    }
  }
}