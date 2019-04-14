namespace HeadFirst.DesignPatterns.Iterator
{
    public class DinerMenuIterator : IIterator
    {
        private readonly MenuItem[] _items;
        private int _position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            if (_position >= _items.Length || _items[_position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Next()
        {
            MenuItem menuItem = _items[_position];
            _position += 1;
            return menuItem;
        }
    }
}