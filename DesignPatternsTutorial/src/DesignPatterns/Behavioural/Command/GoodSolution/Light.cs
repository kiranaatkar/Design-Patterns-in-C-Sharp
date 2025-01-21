namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Command.GoodSolution
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is off");
        }

        public void Dim()
        {
            Console.WriteLine("Light is dimmed");
        }
    }
}