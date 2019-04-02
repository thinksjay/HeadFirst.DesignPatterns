namespace HeadFirst.DesignPatterns.Factory.SimpleFactory
{
    public class PizzaStore
    {
        private readonly SimplePizzaFactory _factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            _factory=factory;
        }

        public Pizza OrderPizza(PizzaType pizzaType)
        {
            Pizza pizza;

            pizza=_factory.CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}