using System;
namespace HeadFirst.DesignPatterns.Combining
{
    public class RubberDuck:IQuackable
    {
        private readonly Observable _observable;

        public RubberDuck()
        {
            _observable=new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public override string ToString()
        {
            return "Rubber Duck";
        }
    }
}