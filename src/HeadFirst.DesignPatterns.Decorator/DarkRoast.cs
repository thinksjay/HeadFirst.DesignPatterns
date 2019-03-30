using System;
namespace HeadFirst.DesignPatterns.Decorator
{
    public class DarkRoast:Beverage
    {
        public DarkRoast()
        {
            description="Dark Roast Coffee";
        }

        public override decimal Cost()
        {
            return .99M;
        }
    }
}