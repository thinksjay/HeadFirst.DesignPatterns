using System;

namespace HeadFirst.DesignPatterns.State
{
    public class WinnerState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count == 0)
            {
                _gumballMachine.SetState(_gumballMachine.SoldOutState);
            }
            else
            {
                _gumballMachine.ReleaseBall();
                Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter");
                if (_gumballMachine.Count > 0)
                {
                    _gumballMachine.SetState(_gumballMachine.NoQuarterState);
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    _gumballMachine.SetState(_gumballMachine.SoldOutState);
                }
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you gumball");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void Refill()
        {

        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning again doesn't get you another gumball!");
        }

        public override string ToString()
        {
            return "despensing two gumballs for your quarter, because YOU'RE A WINNER!";
        }
    }
}