namespace HeadFirst.DesignPatterns.Combining
{
    public interface IQuackObservable
    {
        void RegisterObserver(IObserver observer);
        void NotifyObservers();
    }
}