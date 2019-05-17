using System;
namespace HeadFirst.DesignPatterns.Decorator
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Mocha";
        }

        public override decimal Cost()
        {
            return .20M + _beverage.Cost();
        }
    }
}