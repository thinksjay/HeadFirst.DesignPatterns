using System;

namespace HeadFirst.DesignPatterns.Strategy
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!!!");
        }
    }
}