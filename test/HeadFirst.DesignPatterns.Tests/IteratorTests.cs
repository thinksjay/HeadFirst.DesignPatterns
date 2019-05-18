using System;
using HeadFirst.DesignPatterns.Iterator;
using Xunit;

namespace HeadFirst.DesignPatterns.Tests
{
    public class IteratorTests
    {
        [Fact]
        public void IteratorTest()
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();
            CafeMenu cafeMenu = new CafeMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu, cafeMenu);

            waitress.PrintMenu();
            waitress.PrintVegetarianMenu();

            Console.WriteLine("\nCustomer asks, is the Hotdog vegetarian?");
            Console.WriteLine("Waitress says: ");
            if (waitress.IsItemVegetarian("Hotdog"))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine("\nCustomer asks, are the Waffles vegetarian?");
            Console.WriteLine("Waitress says: ");
            if (waitress.IsItemVegetarian("Waffles"))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}