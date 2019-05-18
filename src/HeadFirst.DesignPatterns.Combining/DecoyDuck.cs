using System;

namespace HeadFirst.DesignPatterns.Combining
{
    public class DecoyDuck : IQuackable
    {
        private readonly Observable _observable;

        public DecoyDuck()
        {
            _observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }
        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }

        public override string ToString()
        {
            return "Decoy Duck";
        }
    }
}