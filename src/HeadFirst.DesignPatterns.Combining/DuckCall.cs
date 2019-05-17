using System;

namespace HeadFirst.DesignPatterns.Combining
{
    public class DuckCall:IQuackable
    {
        private Observable observable;

        public DuckCall()
        {
            observable=new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Kwak");
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
            return "Duck Call";
        }
    }
}