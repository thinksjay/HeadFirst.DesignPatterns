namespace HeadFirst.DesignPatterns.Combining
{
    public class QuackCounter : IQuackable
    {
        private readonly IQuackable _duck;
        public static int NumberOfQuacks { private set; get; } = 0;

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
        }

        public void Quack()
        {
            _duck.Quack();
            NumberOfQuacks++;
        }


        public void RegisterObserver(IObserver observer)
        {
            _duck.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _duck.NotifyObservers();
        }

        public override string ToString()
        {
            return _duck.ToString();
        }
    }
}