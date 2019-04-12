using System;
using System.Text;

namespace HeadFirst.DesignPatterns.Iterator
{
    public class Waitress
    {
        private readonly IMenu _pancakeHouseMenu;
        private readonly IMenu _dinnerMenu;
        private readonly IMenu _cafeMenu;

        public Waitress(IMenu pancakeHouseMenu, IMenu dinnerMenu, IMenu cafeMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinnerMenu = dinnerMenu;
            _cafeMenu = cafeMenu;
        }

        public string PrintMenu()
        {
            StringBuilder sb = new StringBuilder();

            IIterator pancakeIterator = _pancakeHouseMenu.CreateIterator();

            IIterator dinnerIterator = _dinnerMenu.CreateIterator();

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
    }
}