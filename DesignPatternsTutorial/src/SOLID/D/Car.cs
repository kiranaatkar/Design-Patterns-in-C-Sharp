namespace DesignPatternsTutorial.src.SOLID.D
{
    public class Car
    {
        // car depends directly on concrete engine class. 
        // This is bad because if we want to change the engine class, we have to change the car class.
        // Breaking the dependency inversion principle.
        // We can fix this by injecting the engine class into the car class.
        // private Engine engine;
        // public Car()
        // {
        //     this.engine = new Engine();  
        // }
        private IEngine engine;
        
        public Car(IEngine engine)
        {
            this.engine = engine;
        }

        public void StartCar()
        {
            engine.Start();
            Console.WriteLine("Car started");
        }
    }
}