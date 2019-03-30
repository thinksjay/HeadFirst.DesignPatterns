using System;
using Xunit;
using HeadFirst.DesignPatterns.Decorator;
using Xunit.Abstractions;

namespace HeadFirst.DesignPatterns.Tests
{
    public class DecoratorTests
    {
        protected readonly ITestOutputHelper _output;
        public DecoratorTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void DecoratorTest()
        {
            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine($"{beverage2.GetDescription()} ${beverage2.Cost()}");

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine($"{beverage3.GetDescription()} ${beverage3.Cost()}");
        }
    }
}