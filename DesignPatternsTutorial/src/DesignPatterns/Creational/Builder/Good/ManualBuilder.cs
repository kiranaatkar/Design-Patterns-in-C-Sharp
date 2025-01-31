using DesignPatternsTutorial.src.DesignPatterns.Creational.Builder.Components;

namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Builder.Good
{
    public class ManualBuilder : IBuilder
    {
        private Manual _manual;
        public ManualBuilder()
        {
            Reset();
        }
        public IBuilder IsConvertible(bool isConvertible)
        {
            _manual._isConvertible = isConvertible;
            return this;
        }

        public void Reset()
        {
            _manual = new Manual();
        }

        public IBuilder SetCarType(CarType type)
        {
            _manual._type = type;
            return this;
        }

        public IBuilder SetDashboard(Dashboard dashboard)
        {
            _manual._dashboard = dashboard;
            return this;
        }

        public IBuilder SetEngine(Engine engine)
        {
            _manual._engine = engine;
            return this;
        }

        public IBuilder SetGPSNavigator(GPSNavigator gpsNavigator)
        {
            _manual._gpsNavigator = gpsNavigator;
            return this;
        }

        public IBuilder SetWheels(Wheels wheels)
        {
            _manual._wheels = wheels;
            return this;
        }

        public IBuilder SetNumberOfSeats(int seats)
        {
            _manual._seats = seats;
            return this;
        }

        public Manual GetCar()
        {
            Manual result = _manual;
            Reset();
            return result;
        }
    }
}