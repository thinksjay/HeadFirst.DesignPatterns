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
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = "Chicago Style Cheese Pizza";
                    break;
                case PizzaType.Veggie:
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.Name = "Chicago Style Veggie Pizza";
                    break;
                case PizzaType.Clam:
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.Name = "Chicago Style Clam Pizza";
                    break;
                case PizzaType.Pepperoni:
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.Name = "Chicago Style Pepperoni Pizza";
                    break;
            }
            return pizza;
        }
    }

}