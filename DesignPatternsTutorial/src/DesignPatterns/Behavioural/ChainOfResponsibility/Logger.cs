namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.ChainOfResponsibility
{
    public class Logger
    {
        public void Log(HttpRequest request)
        {
            Console.WriteLine("Log: " + request.GetUsername());
        }
    }
}