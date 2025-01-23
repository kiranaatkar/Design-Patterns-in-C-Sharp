namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Template.TemplateMethod
{
    public abstract class Beverage
    {
        public void Prepare()
        {
            BoilWater();
            Brew();
            PourIntoCup();
            AddCondiments();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void PourIntoCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        protected abstract void Brew();
        protected virtual void AddCondiments() { }
    }
}