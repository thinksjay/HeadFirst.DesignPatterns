using System;
using Xunit;
using HeadFirst.DesignPatterns.Strategy;

namespace HeadFirst.DesignPatterns.Tests
{
    public class StrategyTests
    {

        [Fact]
        public void Test1()
        {
            MallardDuck mallard=new MallardDuck();
            RubberDuck rubber=new RubberDuck();
            DecoyDuck decoy=new DecoyDuck();
            Duck model=new ModelDuck();

            mallard.PerformQuack();
            rubber.PerformQuack();
            decoy.PerformQuack();

            model.PerformFly();
            model.FlyBehavior=new FlyRocketPowered();
            model.PerformFly();
        }

        [Fact]
        public void Test2()
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.FlyBehavior=new FlyRocketPowered();
            model.PerformFly();
        }
    }
}
