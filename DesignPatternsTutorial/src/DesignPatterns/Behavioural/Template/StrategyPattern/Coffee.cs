namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Template.StrategyPattern
{
    public class Coffee : Beverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
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