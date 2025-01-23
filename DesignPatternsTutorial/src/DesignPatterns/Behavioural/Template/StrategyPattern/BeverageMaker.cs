namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Template.StrategyPattern
{
    public class BeverageMaker
    {
        private Beverage _beverage;

        public BeverageMaker(Beverage beverage)
        {
            _beverage = beverage;
        }

        public void SetBeverage(Beverage beverage)
        {
            _beverage = beverage;
        }

        public void MakeBeverage()
        {
            BoilWater();
            PourIntoCup();
            _beverage.Prepare();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void PourIntoCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}