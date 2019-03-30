using System;

namespace HeadFirst.DesignPatterns.Strategy
{
    public class FakeQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Qwak");
        }
    }
}