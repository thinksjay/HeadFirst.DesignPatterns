using System;
namespace HeadFirst.DesignPatterns.Factory.FactoryMethod
{
    public class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza()
        {
            Name = "Chicago Style Clam Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Cheese");
            Toppings.Add("Frozen Clams from Chesapeake Bay");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}