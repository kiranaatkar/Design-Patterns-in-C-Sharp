namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Iterator
{
    public class ShoppingList
    {
        private List<string> _items = new List<string>();

        public void Push(string item)
        {
            _items.Add(item);
        }

        public string Pop()
        {
            var item = _items.Last();
            _items.Remove(item);
            return item;
        }

        public List<string> GetList()
        {
            return _items;
        }
    }
}