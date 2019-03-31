namespace HeadFirst.DesignPatterns.Factory.SimplePizzaFactory
{
    public class ClamPizza : Pizza
    {
        public ClamPizza()
        {
            name = "Clam Pizza";
            dough = "Thin crust";
            sauce = "White garlic sauce";
            toppings.Add("Clams");
            toppings.Add("Grated parmesan cheese");
        }
    }
}