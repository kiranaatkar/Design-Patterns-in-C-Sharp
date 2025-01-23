namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Template.StrategyPattern
{
    public class Chamomile : Beverage
    {
        public void Prepare()
        {
            Brew();
        }
        private void Brew()
        {
            Console.WriteLine("Steeping the chamomile");
        }
    }
}