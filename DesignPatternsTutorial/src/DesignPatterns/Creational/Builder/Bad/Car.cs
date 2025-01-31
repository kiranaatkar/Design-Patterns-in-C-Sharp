using DesignPatternsTutorial.src.DesignPatterns.Creational.Builder.Components;

namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Builder.Bad
{
    public class Car
    {
        public CarType _type;
        public int _seats;
        public Engine _engine;
        public bool _isConvertible;
        public Dashboard _dashboard;
        public Wheels _wheels;
        public GPSNavigator _gpsNavigator;
        
        // fields specific to this class
        public double Fuel { get; set; }

        public Car(CarType type, int seats, Engine engine, bool isConvertible, Dashboard dashboard, Wheels wheels, GPSNavigator gpsNavigator)
        {
            _type = type;
            _seats = seats;
            _engine = engine;
            _isConvertible = isConvertible;
            _dashboard = dashboard;
            _wheels = wheels;
            _gpsNavigator = gpsNavigator;
        }
    }
}