namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Composite
{
    public class Box : Item
    {
        private List<Item> _items = new List<Item>();

        public void Add(Item item)
        {
            _items.Add(item);
        }
        
        public float GetPrice()
        {
            float price = 0.0f;
            foreach (Item item in _items)
            {
                price += item.GetPrice();
            }
            return price;
        }
    }
}