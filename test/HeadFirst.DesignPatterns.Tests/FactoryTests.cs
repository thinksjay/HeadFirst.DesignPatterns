using System;
using Xunit;
using HeadFirst.DesignPatterns.Factory;
using HeadFirst.DesignPatterns.Factory.SimplePizzaFactory;
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
        public void SimplePizzaFactoryTest()
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);

            Pizza pizza = store.OrderPizza(PizzaType.Cheese);

            Console.WriteLine($"We ordered a {pizza.Name}{Environment.NewLine}");
            Console.WriteLine(pizza.ToString());

            pizza = store.OrderPizza(PizzaType.Veggie);
            Console.WriteLine("We ordered a {pizza.Name}{Environment.NewLine}");
            Console.WriteLine(pizza.ToString());
        }
    }
}