using System;
namespace HeadFirst.DesignPatterns.Factory.FactoryMethod
{
    public abstract class PizzaStore{
       public abstract Pizza CreatePizza(PizzaType pizzaType);

       public Pizza OrderPizza(PizzaType pizzaType)
       {
           Pizza pizza=CreatePizza(pizzaType);
           Console.WriteLine($"---Making a {pizza.Name} ---");
           pizza.Prepare();
           pizza.Bake();
           pizza.Cut();
           pizza.Box();
           return pizza;
       }
    }
}