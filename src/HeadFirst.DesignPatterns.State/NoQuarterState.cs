using System;

namespace HeadFirst.DesignPatterns.State
{
    public class NoQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine=gumballMachine;
        }
        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
        }

        public void Refill()
        {
            
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }

        public override string ToString() 
        {
            return "waiting for quarter";
        }
    }
}