namespace HeadFirst.DesignPatterns.Factory.SimplePizzaFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = null;
            switch (pizzaType)
            {
                case  PizzaType.Cheese:
                pizza=new CheesePizza();
                break;
                case PizzaType.Clam:
                pizza=new ClamPizza();
                break;
                case PizzaType.Pepperoni:
                pizza=new PepperoniPizza();
                break;
                case PizzaType.Veggie:
                pizza=new VeggiePizza();
                break;
            }

            return pizza;
        }
    }
}