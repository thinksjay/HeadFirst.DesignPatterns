using System;

namespace HeadFirst.DesignPatterns.Combining
{
    public class MallardDuck : IQuackable
    {
        private Observable observable;

        public MallardDuck()
        {
            observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public override string ToString()
        {
            return "Mallard Duck";
        }
    }
}