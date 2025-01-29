namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Facade
{
    public class OrderFufillment
    {
        private Inventory _inventory;

        public OrderFufillment(Inventory inventory)
        {
            _inventory = inventory;
        }

        public void Fufill(string name, string address, string[] items)
        {
            Console.WriteLine($"Fufilling order for {name} at {address}");
            foreach (var item in items)
            {
                _inventory.ReduceInventory(item, 1);
            }
        }
    }
}