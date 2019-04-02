using System;
using Xunit;
using HeadFirst.DesignPatterns.Factory;
using SF=HeadFirst.DesignPatterns.Factory.SimpleFactory;
using FM=HeadFirst.DesignPatterns.Factory.FactoryMethod;
using Xunit.Abstractions;

namespace HeadFirst.DesignPatterns.Tests
{
    public class FactoryTests
    {
        protected readonly ITestOutputHelper _output;
        public FactoryTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void SimpleFactoryPatternTest()
        {
            SF.SimplePizzaFactory factory = new SF.SimplePizzaFactory();
            SF.PizzaStore store = new SF.PizzaStore(factory);

            SF.Pizza pizza = store.OrderPizza(PizzaType.Cheese);

            Console.WriteLine($"We ordered a {pizza.Name}{Environment.NewLine}");
            Console.WriteLine(pizza.ToString());

            pizza = store.OrderPizza(PizzaType.Veggie);
            Console.WriteLine("We ordered a {pizza.Name}{Environment.NewLine}");
            Console.WriteLine(pizza.ToString());
        }

        [Fact]
        public void FactoryMethodPatternTest()
        {
            FM.PizzaStore nyStore = new FM.NYPizzaStore();
            FM.PizzaStore chicagoStore = new FM.ChicagoPizzaStore();

            FM.Pizza pizza = nyStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

            pizza = chicagoStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine($"Joel ordered a {pizza.Name}\n");

            pizza = nyStore.OrderPizza(PizzaType.Clam);
            Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

            pizza = chicagoStore.OrderPizza(PizzaType.Clam);
            Console.WriteLine($"Joel ordered a {pizza.Name}\n");

            pizza = nyStore.OrderPizza(PizzaType.Pepperoni);
            Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

            pizza = chicagoStore.OrderPizza(PizzaType.Pepperoni);
           Console.WriteLine($"Joel ordered a {pizza.Name}\n");

            pizza = nyStore.OrderPizza(PizzaType.Veggie);
            Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

            pizza = chicagoStore.OrderPizza(PizzaType.Veggie);
            Console.WriteLine($"Joel ordered a {pizza.Name}\n");
        }
    }
}