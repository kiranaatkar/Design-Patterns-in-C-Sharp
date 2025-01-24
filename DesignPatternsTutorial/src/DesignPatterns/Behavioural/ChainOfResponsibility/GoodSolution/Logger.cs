namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.ChainOfResponsibility.GoodSolution
{
    public class Logger : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Log: " + request.GetUsername());
            return false;
        }
    }
}