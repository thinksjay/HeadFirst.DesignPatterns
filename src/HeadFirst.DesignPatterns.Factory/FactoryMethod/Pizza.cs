using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirst.DesignPatterns.Factory.FactoryMethod
{
    public abstract class Pizza
    {
        public string Name { get; internal set; }
        public string Dough{ get; internal set; }

        public string Sauce{ get; internal set; }

        public List<string> Toppings{get;internal set;}=new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Prepare {Name}");
            Console.WriteLine($"Tossing dough ...");
            Console.WriteLine($"Adding sauce ...");
            Console.WriteLine($"Adding toppings: ");
            foreach (var topping in Toppings)
            {
                Console.WriteLine($"   {topping}");
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cut the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public override String ToString()
        {
            StringBuilder display = new StringBuilder();
            display.Append($"---- {Name} ----\n");
            display.Append($"{Dough}\n");
            display.Append($"{Sauce}\n");
            foreach (var topping in Toppings)
            {
                display.Append($"{topping}\n");
            }
            return display.ToString();
        }
    }
}