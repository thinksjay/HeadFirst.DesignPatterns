using System;
namespace HeadFirst.DesignPatterns.Decorator
{
    public class HouseBlend:Beverage
    {
        public HouseBlend()
        {
            description="House Blend Coffee";
        }

        public override decimal Cost()
        {
            return .89M;
        }
    }
}