using System;

namespace HeadFirst.DesignPatterns.Strategy
{
    internal class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}