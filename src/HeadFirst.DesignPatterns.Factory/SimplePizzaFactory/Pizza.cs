using System;
using System.Text;
using System.Collections.Generic;

namespace HeadFirst.DesignPatterns.Factory.SimplePizzaFactory
{
    public abstract class Pizza
    {
       protected string name;
        protected string dough;
        protected string sauce;

        protected List<string> toppings = new List<string>();

        public string Name { get { return name; } }

        public void Prepare()
        {
            Console.WriteLine($"PreParing {name}");
        }

        public void Bake()
        {
            Console.WriteLine($"Baking {name}");
        }

        public void Cut()
        {
            Console.WriteLine($"Cutting {name}");
        }

        public void Box()
        {
            Console.WriteLine($"Boxing {name}");
        }

        public override string ToString()
        {
            // code to display pizza name and ingredients
            StringBuilder display = new StringBuilder();
            display.Append($"---- {name} ----\n");
            display.Append($"{dough}{Environment.NewLine}");
            display.Append($"{sauce}{Environment.NewLine}");
            foreach (var topping in toppings)
            {
            }
            return display.ToString();
        }
    }
}