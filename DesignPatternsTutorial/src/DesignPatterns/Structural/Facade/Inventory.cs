namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Facade
{
    public class Inventory
    {
        public bool CheckInventory(string itemId)
        {
            return true;
        }

        public void ReduceInventory(string itemId, int amount)
        {
            Console.WriteLine($"Reducing inventory for item {itemId} by {amount}");
        }
    }
}