namespace HeadFirst.DesignPatterns.Factory.SimpleFactory
{
public class VeggiePizza : Pizza {
	public VeggiePizza() {
		name = "Veggie Pizza";
		dough = "Crust";
		sauce = "Marinara sauce";
		toppings.Add("Shredded mozzarella");
		toppings.Add("Grated parmesan");
		toppings.Add("Diced onion");
		toppings.Add("Sliced mushrooms");
		toppings.Add("Sliced red pepper");
		toppings.Add("Sliced black olives");
	}
}
}