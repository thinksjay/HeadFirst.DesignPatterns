using System;
namespace HeadFirst.DesignPatterns.Decorator
{
    public class Whip : CondimentDecorator
    {
        private Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Whip";
        }

        public override decimal Cost()
        {
            return .10M + _beverage.Cost();
        }
    }
}