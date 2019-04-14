using HeadFirst.DesignPatterns.TemplateMethod;
using Xunit;
using System;

namespace HeadFirst.DesignPatterns.Tests
{
    public class TemplateMethodTests
    {
        [Fact]
        public void TemplateMethodTest()
        {
            Tea tea = new Tea();
            Coffee coffee = new Coffee();

            Console.WriteLine("${Environment.NewLine}Making tea...");
            tea.PrepareRecipe();

            Console.WriteLine($"{Environment.NewLine}Making coffee...");
            coffee.PrepareRecipe();

            TeaWithHook teaHook = new TeaWithHook();
            CoffeeWithHook coffeeHook = new CoffeeWithHook();

            Console.WriteLine($"{Environment.NewLine}Making tea...");
            teaHook.PrepareRecipe();

            Console.WriteLine($"{Environment.NewLine}Making coffee...");
            coffeeHook.PrepareRecipe();
        }
    }
}