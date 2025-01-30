namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Singleton
{
    public class Test
    {
        public static void Run()
        {
            AppSettings appSettings = new AppSettings();
            Console.WriteLine(appSettings.Get("theme"));
        }
    }
}