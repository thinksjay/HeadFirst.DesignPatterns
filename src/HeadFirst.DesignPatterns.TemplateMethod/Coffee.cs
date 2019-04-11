using System;

namespace HeadFirst.DesignPatterns.TemplateMethod
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }
}