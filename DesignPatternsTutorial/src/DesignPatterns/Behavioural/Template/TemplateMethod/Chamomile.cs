namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Template.TemplateMethod
{
    public class Chamomile : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the chamomile");
        }
    }
}