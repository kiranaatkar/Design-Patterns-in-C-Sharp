using DesignPatternsTutorial.src.DesignPatterns.Creational.Builder.Components;

namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Builder.Good
{
    public class CarBuilder : IBuilder
    {
        private Car _car;
        public CarBuilder()
        {
            Reset();
        }
        public IBuilder IsConvertible(bool isConvertible)
        {
            _car._isConvertible = isConvertible;
            return this;
        }

        public void Reset()
        {
            _car = new Car();
        }

        public IBuilder SetCarType(CarType type)
        {
            _car._type = type;
            return this;
        }

        public IBuilder SetDashboard(Dashboard dashboard)
        {
            _car._dashboard = dashboard;
            return this;
        }

        public IBuilder SetEngine(Engine engine)
        {
            _car._engine = engine;
            return this;
        }

        public IBuilder SetGPSNavigator(GPSNavigator gpsNavigator)
        {
            _car._gpsNavigator = gpsNavigator;
            return this;
        }

        public IBuilder SetWheels(Wheels wheels)
        {
            _car._wheels = wheels;
            return this;
        }

         public IBuilder SetNumberOfSeats(int seats)
        {
            _car._seats = seats;
            return this;
        }

        public Car GetCar()
        {
            Car result = _car;
            Reset();
            return result;
        }
    }
}