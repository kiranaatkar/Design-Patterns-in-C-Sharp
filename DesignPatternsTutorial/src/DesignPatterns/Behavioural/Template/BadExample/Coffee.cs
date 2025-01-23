namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Template.BadExample
{
    public class Coffee
    {
        public void MakeBeverage()
        {
            BoilWater();
            Brew();
            PourWaterIntoCuop();
            AddCondiments();
        }
        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        private void PourWaterIntoCuop()
        {
            Console.WriteLine("Pouring water into cup");
        }
        private void Brew()
        {
            Console.WriteLine("brewing coffee");
        }
        private void AddCondiments()
        {
            if (CustomerWantsCondiments())
            {
                Console.WriteLine("adding condiments to the coffee");
            }
        }

        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Do you want condiments? (y/n)");
            var response = Console.ReadLine();
            return response.ToLower() == "y";
        }
    }
}