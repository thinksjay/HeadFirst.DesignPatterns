using System;
namespace HeadFirst.DesignPatterns.Decorator
{
    public class Milk : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Milk";
        }

        public override decimal Cost()
        {
            return .10M + _beverage.Cost();
        }
    }
}