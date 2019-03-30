using System;
namespace HeadFirst.DesignPatterns.Decorator
{
    public class Soy : CondimentDecorator
    {
        private Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Soy";
        }

        public override decimal Cost()
        {
            return .15M + _beverage.Cost();
        }
    }
}