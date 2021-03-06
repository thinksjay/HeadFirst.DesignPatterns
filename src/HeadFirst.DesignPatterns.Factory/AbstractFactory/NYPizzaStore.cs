namespace HeadFirst.DesignPatterns.Factory.AbstractFactory
{
    public class NYPizzaStore : PizzaStore
    {

        protected override Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory =
                new NYPizzaIngredientFactory();
            switch (pizzaType)
            {
                case PizzaType.Cheese:
                    pizza = new CheesePizza(ingredientFactory)
                    {
                        Name = "New York Style Cheese Pizza"
                    };
                    break;
                case PizzaType.Veggie:
                    pizza = new VeggiePizza(ingredientFactory)
                    {
                        Name = "New York Style Veggie Pizza"
                    };
                    break;
                case PizzaType.Clam:
                    pizza = new ClamPizza(ingredientFactory)
                    {
                        Name = "New York Style Clam Pizza"
                    };
                    break;
                case PizzaType.Pepperoni:
                    pizza = new PepperoniPizza(ingredientFactory)
                    {
                        Name = "New York Style Pepperoni Pizza"
                    };
                    break;
            }

            return pizza;
        }
    }
}