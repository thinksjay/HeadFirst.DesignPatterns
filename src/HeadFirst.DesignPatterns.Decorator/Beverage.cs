using System;
namespace HeadFirst.DesignPatterns.Decorator
{
    public abstract class Beverage
    {
       protected string description="Unknown Beverage";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract decimal Cost();
    }
}