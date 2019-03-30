using System;
namespace HeadFirst.DesignPatterns.Strategy
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket");
        }
    }
}