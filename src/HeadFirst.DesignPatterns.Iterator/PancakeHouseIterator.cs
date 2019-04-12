using System.Collections;

namespace HeadFirst.DesignPatterns.Iterator
{
    public class PancakeHouseIterator : IIterator
    {
        private readonly ArrayList _menuItems;
        private int _position = 0;

        public PancakeHouseIterator(ArrayList menuItems)
        {
            _menuItems = menuItems;
        }

        public bool HasNext()
        {
            if(_position >= _menuItems.Count || _menuItems[_position] == null)
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
            MenuItem menuItem = (MenuItem)_menuItems[_position];
            _position += 1;
            return menuItem;
        }
    }
}