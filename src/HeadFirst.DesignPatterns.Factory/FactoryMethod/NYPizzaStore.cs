namespace HeadFirst.DesignPatterns.Factory.FactoryMethod
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaType pizzaType)
        {
            switch(pizzaType)
            {
                case PizzaType.Cheese:
                    return new NYStyleCheesePizza();
                case PizzaType.Clam:
                    return new NYStyleClamPizza();
                case PizzaType.Pepperoni:
                    return new NYStylePepperoniPizza();
                case PizzaType.Veggie:
                    return new NYStyleVeggiePizza();
                default: return null;
            }
        }
    }
}