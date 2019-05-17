using System;

namespace HeadFirst.DesignPatterns.Combining
{
    public class DecoyDuck : IQuackable
    {
        private Observable observable;

        public DecoyDuck()
        {
            observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
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
            return "Decoy Duck";
        }
    }
}