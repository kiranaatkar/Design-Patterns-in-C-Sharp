using DesignPatternsTutorial.src.DesignPatterns.Creational.Builder.Components;

namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Builder.Good
{
    public class Director
    {
        public void ConstructSportsCar (IBuilder builder)
        {
            builder.Reset();
            builder.SetCarType(CarType.Sports);
            builder.SetNumberOfSeats(2);
            builder.IsConvertible(true);
            builder.SetEngine(new Engine());
            builder.SetWheels(new Wheels(20));
            builder.SetDashboard(new Dashboard(true));
            builder.SetGPSNavigator(new GPSNavigator());
        }

        public void ConstructSUV (IBuilder builder)
        {
            builder.Reset();
            builder.SetCarType(CarType.SUV);
            builder.SetNumberOfSeats(4);
            builder.IsConvertible(false);
            builder.SetEngine(new Engine());
            builder.SetWheels(new Wheels(22));
            builder.SetDashboard(new Dashboard(true));
            builder.SetGPSNavigator(new GPSNavigator());
        }
    }
}