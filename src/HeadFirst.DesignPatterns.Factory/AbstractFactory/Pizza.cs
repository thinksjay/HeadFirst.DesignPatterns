using System;
using System.Text;

namespace HeadFirst.DesignPatterns.Factory.AbstractFactory
{
    public abstract class Pizza
    {
        public string Name { get; set; }

        protected IDough dough;
        protected ISauce sauce;
        protected IVeggies[] veggies;
        protected ICheese cheese;
        protected IPepperoni pepperoni;
        protected IClams clam;

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"---- {Name} ----\n");
            if (dough != null)
            {
                result.Append(dough);
                result.Append(Environment.NewLine);
            }
            if (sauce != null)
            {
                result.Append(sauce);
                result.Append(Environment.NewLine);
            }
            if (cheese != null)
            {
                result.Append(cheese);
                result.Append(Environment.NewLine);
            }
            if (veggies != null)
            {
                for (int i = 0; i < veggies.Length; i++)
                {
                    result.Append(veggies[i]);
                    if (i < veggies.Length - 1)
                    {
                        result.Append(", ");
                    }
                }
                result.Append(Environment.NewLine);
            }
            if (clam != null)
            {
                result.Append(clam);
                result.Append(Environment.NewLine);
            }
            if (pepperoni != null)
            {
                result.Append(pepperoni);
                result.Append(Environment.NewLine);
            }
            return result.ToString();
        }
    }
}