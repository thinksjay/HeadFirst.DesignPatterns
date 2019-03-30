using System;

namespace HeadFirst.DesignPatterns.Strategy
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            FlyBehavior=new FlyNoWay();
            QuackBehavior=new MuteQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a duck Decoy");
        }
    }
}

