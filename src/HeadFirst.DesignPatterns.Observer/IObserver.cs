namespace HeadFirst.DesignPatterns.Observer
{
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}