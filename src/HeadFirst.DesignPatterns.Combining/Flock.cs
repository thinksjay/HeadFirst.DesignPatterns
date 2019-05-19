using System.Collections.Generic;
namespace HeadFirst.DesignPatterns.Combining
{
    public class Flock : IQuackable
    {
       private readonly List<IQuackable> ducks = new List<IQuackable>();

        public void Add(IQuackable duck)
        {
            ducks.Add(duck);
        }

        public void Quack()
        {
            foreach (var duck in ducks)
            {
                duck.Quack();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            foreach (var duck in ducks)
            {
                duck.RegisterObserver(observer);
            }
        }

        public void NotifyObservers() { }

        public override string ToString()
        {
            return "Flock of Ducks";
        }
    }
}