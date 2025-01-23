namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Template.StrategyPattern
{
    public class Tea : Beverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }
        private void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
        private void AddCondiments()
        {
            if (CustomerWantsCondiments())
            {
                Console.WriteLine("Adding condiments to the tea");
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