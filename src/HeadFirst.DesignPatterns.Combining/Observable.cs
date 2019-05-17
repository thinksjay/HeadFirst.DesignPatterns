using System.Collections.Generic;

namespace HeadFirst.DesignPatterns.Combining
{
    public class Observable : IQuackObservable
    {
        List<IObserver> observers = new List<IObserver>();

        private readonly IQuackObservable _duck;

        public Observable(IQuackObservable duck) => _duck = duck;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void NotifyObservers()
        {
            foreach(var observer in observers)
            {
                observer.Update(_duck);
            }
        }

        public System.Collections.Generic.IReadOnlyList<IObserver> Observers
        {
            get
            {
                return observers.AsReadOnly();
            }
        }
    }
}