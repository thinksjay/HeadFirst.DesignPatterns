using System;

namespace HeadFirst.DesignPatterns.State
{
    public class HasQuarterState : IState
    {
        private Random _randomWinner=new Random(DateTime.Now.Millisecond);
        private readonly GumballMachine _gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine=gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            int winner=_randomWinner.Next(10);
            if((winner==0)&&(_gumballMachine.Count>1))
            {
                _gumballMachine.SetState(_gumballMachine.WinnerState);
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.SoldState);
            }
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void Refill()
        {
            Console.WriteLine("waiting for turn of crank");
        }
    }
}