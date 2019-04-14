using System;
using System.Text;

namespace HeadFirst.DesignPatterns.Iterator
{
    public class Waitress
    {
        private readonly IMenu _pancakeHouseMenu;
        private readonly IMenu _dinerMenu;
        private readonly IMenu _cafeMenu;

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu, IMenu cafeMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
            _cafeMenu = cafeMenu;
        }

        public string PrintMenu()
        {
            StringBuilder sb = new StringBuilder();

            IIterator pancakeIterator = _pancakeHouseMenu.CreateIterator();

            IIterator dinnerIterator = _dinerMenu.CreateIterator();

            IIterator cafeIterator = _cafeMenu.CreateIterator();

            sb.Append($"MENU{Environment.NewLine}----{Environment.NewLine}BREAKFAST{Environment.NewLine}");

            sb.Append(PrintMenu(pancakeIterator));

            sb.Append($"{Environment.NewLine}LUNCH{Environment.NewLine}");

            sb.Append(PrintMenu(dinnerIterator));

            sb.Append($"{Environment.NewLine}Dinner{Environment.NewLine}");

            sb.Append(PrintMenu(cafeIterator));

            return sb.ToString();
        }

        public string PrintMenu(IIterator iterator)
        {
            StringBuilder sb = new StringBuilder();

            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();

                sb.Append($"{menuItem.Name}, ");

                sb.Append($"{menuItem.Price} -- ");

                sb.Append($"{menuItem.Description}{Environment.NewLine}");
            }

            return sb.ToString();
        }

        public void printVegetarianMenu()
        {
            printVegetarianMenu(_pancakeHouseMenu.CreateIterator());
            printVegetarianMenu(_dinerMenu.CreateIterator());
        }

        public bool isItemVegetarian(String name)
        {
            IIterator breakfastIterator = _pancakeHouseMenu.CreateIterator();
            if (isVegetarian(name, breakfastIterator))
            {
                return true;
            }
            IIterator dinnerIterator = _dinerMenu.CreateIterator();
            if (isVegetarian(name, dinnerIterator))
            {
                return true;
            }
            return false;
        }


        private void printVegetarianMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next() as MenuItem;
                if (menuItem.IsVegetarian)
                {
                    Console.WriteLine(menuItem.Name);
                    Console.WriteLine("\t\t" + menuItem.Price);
                    Console.WriteLine("\t" + menuItem.Description);
                }
            }
        }

        private bool isVegetarian(String name, IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next() as MenuItem;
                if (menuItem.Name.Equals(name))
                {
                    if (menuItem.IsVegetarian)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
