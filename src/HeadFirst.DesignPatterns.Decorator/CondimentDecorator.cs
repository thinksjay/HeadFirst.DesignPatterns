using System;
namespace HeadFirst.DesignPatterns.Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        public override abstract string GetDescription();
    }
}