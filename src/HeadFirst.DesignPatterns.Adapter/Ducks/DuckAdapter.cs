using System;

namespace HeadFirst.DesignPatterns.Adapter.Ducks
{
    public class DuckAdapter : ITurkey
    {
        private readonly IDuck _duck;
        private readonly Random _rand;

        public DuckAdapter(IDuck duck)
        {
            _duck = duck;
            _rand = new Random();
        }

        public void Gobble()
        {
            _duck.Quack();
        }

        public void Fly()
        {
            if (_rand.Next(5) == 0)
            {
                _duck.Fly();
            }
        }
    }
}