using DesignPatternsTutorial.src.DesignPatterns.Creational.Builder.Components;

namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Builder.Good
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
    }
}