using HeadFirst.DesignPatterns.Adapter.Ducks;
using Xunit;
using System;

namespace HeadFirst.DesignPatterns.Tests
{
    public class AdapterTests
    {
        [Fact]
        public void DuckAdapterTest()
        {
            MallardDuck duck = new MallardDuck();
            ITurkey duckAdapter = new DuckAdapter(duck);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The DuckAdapter says...");
                duckAdapter.Gobble();
                duckAdapter.Fly();
            }
        }
        [Fact]
        public void TurkeyAdapterTest()
        {
            MallardDuck duck = new MallardDuck();

            WildTurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine($"{Environment.NewLine}The Duck says...");
            TestDuck(duck);

            Console.WriteLine($"{Environment.NewLine}The TurkeyAdapter says...");
            TestDuck(turkeyAdapter);
        }
        private void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}