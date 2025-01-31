using DesignPatternsTutorial.src.DesignPatterns.Creational.Builder.Components;

namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Builder.Good
{
    public class Manual
    {
        public CarType _type;
        public int _seats;
        public Engine _engine;
        public bool _isConvertible;
        public Dashboard _dashboard;
        public Wheels _wheels;
        public GPSNavigator _gpsNavigator;

        public string Print()
        {
            string info = "";
            info += "Type of car: " + _type + "\n";
            info += "Number of seats: " + _seats + "\n";
            info += "Convertible: " + _isConvertible + "\n";
            info += "Dashboard: has rev counter - " + _dashboard._hasRevCounter + "\n";
            info += "Wheels: diameter - " + _wheels.GetDiameterInInches() + "\n";
            if (_gpsNavigator != null)
                info += "GPS Navigator \n";
            return info;
        }
    }
}