using System.Collections;

namespace HeadFirst.DesignPatterns.Iterator
{
 public class CafeMenuIterator : IIterator
    {
        private readonly Hashtable _menuItems = new Hashtable();
        private int _position = 1;

        public CafeMenuIterator(Hashtable menuItems)
        {
            _menuItems = menuItems;
        }

        public bool HasNext()
        {
            return _position <= _menuItems.Count ? true : false ;
        }
        public object Next()
        {
            MenuItem menuItem = (MenuItem)_menuItems[_position];
            _position += 1;
            return menuItem;
        }
    }
}