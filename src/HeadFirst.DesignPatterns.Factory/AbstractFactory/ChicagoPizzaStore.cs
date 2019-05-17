namespace HeadFirst.DesignPatterns.Factory.AbstractFactory
{
    public class ChicagoPizzaStore : PizzaStore
    {

        protected override Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory =
            new ChicagoPizzaIngredientFactory();

            switch (pizzaType)
            {
                case PizzaType.Cheese:
                    pizza = new CheesePizza(ingredientFactory)
                    {
                        Name = "Chicago Style Cheese Pizza"
                    };
                    break;
                case PizzaType.Veggie:
                    pizza = new VeggiePizza(ingredientFactory)
                    {
                        Name = "Chicago Style Veggie Pizza"
                    };
                    break;
                case PizzaType.Clam:
                    pizza = new ClamPizza(ingredientFactory)
                    {
                        Name = "Chicago Style Clam Pizza"
                    };
                    break;
                case PizzaType.Pepperoni:
                    pizza = new PepperoniPizza(ingredientFactory)
                    {
                        Name = "Chicago Style Pepperoni Pizza"
                    };
                    break;
            }
            return pizza;
        }
    }

}