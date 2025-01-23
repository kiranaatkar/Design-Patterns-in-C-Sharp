namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Template.TemplateMethod
{
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
        protected override void AddCondiments()
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