using DesignPatternsTutorial.src.DesignPatterns.Creational.Builder.Components;

namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Builder.Good
{
    public interface IBuilder
    {
         void Reset();
         IBuilder SetCarType(CarType type);
         IBuilder SetNumberOfSeats(int seats);
         IBuilder IsConvertible(bool isConvertible);
         IBuilder SetEngine(Engine engine);
         IBuilder SetWheels(Wheels wheels);
         IBuilder SetDashboard(Dashboard dashboard);
         IBuilder SetGPSNavigator(GPSNavigator gpsNavigator);
    }
}