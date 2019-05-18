using System;
using Xunit;
using HeadFirst.DesignPatterns.Combining;
using Xunit.Abstractions;

namespace HeadFirst.DesignPatterns.Tests
{
    public class CombiningTests
    {
        protected readonly ITestOutputHelper _output;
        public CombiningTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void CombiningTest()
        {
            AbstractDuckFactory duckFactory = new CountingDuckFactory();

            Simulate(duckFactory);
        }

        private void Simulate(AbstractDuckFactory duckFactory)
        {
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            Flock flockOfDucks = new Flock();

            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            Flock flockOfMallards = new Flock();

            IQuackable mallardOne = duckFactory.CreateMallardDuck();
            IQuackable mallardTwo = duckFactory.CreateMallardDuck();
            IQuackable mallardThree = duckFactory.CreateMallardDuck();
            IQuackable mallardFour = duckFactory.CreateMallardDuck();

            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);

            flockOfDucks.Add(flockOfMallards);

            Console.WriteLine($"{System.Environment.NewLine}Duck Simulator: With Observer");

            Quackologist quackologist = new Quackologist();
            flockOfDucks.RegisterObserver(quackologist);

            Simulate(flockOfDucks);

            Console.WriteLine($"{System.Environment.NewLine}The ducks quacked {QuackCounter.NumberOfQuacks} times");
        }

        void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}