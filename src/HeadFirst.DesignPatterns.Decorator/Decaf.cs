using System;
namespace HeadFirst.DesignPatterns.Decorator
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf Coffee";
        }

        public override decimal Cost()
        {
            return 1.05M;
        }
    }

}