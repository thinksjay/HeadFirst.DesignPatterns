namespace HeadFirst.DesignPatterns.Factory.SimpleFactory
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            name = "Cheese Pizza";
            dough = "Regular Crust";
            sauce = "Marinara Pizza Sauce";
            toppings.Add("Fresh Mozzarella");
            toppings.Add("Parmesan");
        }
    }
}