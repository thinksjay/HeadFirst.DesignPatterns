using System.Collections;

namespace HeadFirst.DesignPatterns.Iterator
{
    public class PancakeHouseMenu : IMenu
    {
       private readonly ArrayList _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new ArrayList();

            AddItem("K&B's Pancake Breakfast",
                "Pancakes with scrambled eggs, and toast",
                true,2.99);

            AddItem("Regular Pancake Breakfast",
                "Pancakes with fried eggs, and sausage",
                false,2.99);

            AddItem("Blueberry Pancakes",
                "Pancakes made with fresh blueberries",
                true,3.49);

            AddItem("Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                true,3.59);
        }

        public void AddItem(string name, string description, 
            bool isVegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description,
                isVegetarian, price);

            _menuItems.Add(menuItem);
        }

        public IIterator CreateIterator()
        {
            return new PancakeHouseIterator(_menuItems);
        }
    }
}