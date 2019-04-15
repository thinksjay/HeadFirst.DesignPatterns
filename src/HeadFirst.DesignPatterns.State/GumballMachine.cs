using System;
using System.Text;

namespace HeadFirst.DesignPatterns.State
{
    public class GumballMachine
    {
        private readonly IState _soldOutState;
        private readonly IState _noQuarterState;
        private readonly IState _hasQuarterState;
        private IState _soldState;
        private readonly IState _winnerState;

        private IState _currentState ;
        private int _count = 0;


        public int Count { get { return _count; } }
        public IState CurrentState { get { return _currentState; } }

        public IState SoldOutState { get { return _soldOutState; } }

        public IState NoQuarterState { get { return _noQuarterState; } }

        public IState HasQuarterState { get { return _hasQuarterState; } }

        public IState SoldState { get { return _soldState; } }

        public IState WinnerState { get { return _winnerState; } }

        public GumballMachine(int numberGumballs)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _winnerState = new WinnerState(this);

            _count = numberGumballs;
            if (numberGumballs > 0)
            {
                _currentState = _noQuarterState;
            }
            else
            {
                 _currentState = _soldOutState;
            }
        }

        public void InsertQuarter()
        {
            _soldState = new SoldState(this);
            _currentState.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _currentState.EjectQuarter();
        }

        public void TurnCrank()
        {
            _currentState.TurnCrank();
            _currentState.Dispense();
        }

        public void SetState(IState state)
        {
            _currentState = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (_count > 0)
            {
                _count -= 1;
            }
        }

        public void Refill(int count)
        {
            _count += count;
            Console.WriteLine($"The gumball machine was just refilled; it's new count is:{Count}");
            _currentState.Refill();
        }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append($"{Environment.NewLine}Mighty Gumball, Inc.");
            result.Append($"{Environment.NewLine}C#-enabled Standing Gumball Model #2004");
            result.Append($"{Environment.NewLine}Inventory: {Count} gumball");
            if (Count != 1)
            {
                result.Append("s");
            }
            result.Append($"{Environment.NewLine}");
            result.Append($"Machine is {CurrentState}{Environment.NewLine}");
            return result.ToString();
        }
    }
}