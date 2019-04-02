using System;

namespace HeadFirst.DesignPatterns.Factory.FactoryMethod
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.Cheese:
                    return new ChicagoStyleCheesePizza();
                case PizzaType.Clam:
                    return new ChicagoStyleClamPizza();
                case PizzaType.Pepperoni:
                    return new ChicagoStylePepperoniPizza();
                case PizzaType.Veggie:
                    return new ChicagoStyleVeggiePizza();
                default: return null;
            }
        }
    }
}