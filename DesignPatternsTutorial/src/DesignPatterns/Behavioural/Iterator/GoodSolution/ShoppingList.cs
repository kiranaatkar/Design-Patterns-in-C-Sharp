namespace DesignPatternsTutorial.src.DesignPatterns.Behavioural.Iterator.GoodSolution
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

        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }

        private class ListIterator : IIterator<string>
        {
            private ShoppingList _shoppingList;
            private int _index;

            public ListIterator(ShoppingList shoppingList)
            {
                this._shoppingList = shoppingList;
                this._index = 0;
            }

            public string Current()
            {
                return _shoppingList.GetList()[_index];
            }

            public bool HasNext()
            {
                return _index < _shoppingList.GetList().Count;
            }

            public string Next()
            {
                return _shoppingList.GetList()[_index++];
            }
        }
    }
}