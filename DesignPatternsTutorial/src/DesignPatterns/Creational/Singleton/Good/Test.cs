namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Singleton.Good
{
    public class Test
    {
        public static void Run()
        {
            Console.WriteLine(AppSettings.GetInstance().Get("theme"));
        }
    }
}