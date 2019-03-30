using System;
namespace HeadFirst.DesignPatterns.Decorator
{
    public class Espresso:Beverage
    {
        public Espresso()
        {
            description="Espresso";
        }

        public override decimal Cost()
        {
            return 1.99M;
        }
    }
}