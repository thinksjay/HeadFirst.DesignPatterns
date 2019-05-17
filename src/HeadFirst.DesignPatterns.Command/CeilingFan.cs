using System;

namespace HeadFirst.DesignPatterns.Command
{
    public class CeilingFan
    {
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;
        private readonly string _location;
        private int _speed;

        public int Speed { get { return _speed; } }

        public CeilingFan(string location)
        {
            _location = location;
        }

        public void High()
        {
            // turns the ceiling fan on to high
            _speed = HIGH;
            Console.WriteLine($"{_location} ceiling fan is on high");
        }

        public void Medium()
        {
            // turns the ceiling fan on to medium
            _speed = MEDIUM;
            Console.WriteLine($"{_location} ceiling fan is on medium");
        }

        public void Low()
        {
            // turns the ceiling fan on to low
            _speed = LOW;
            Console.WriteLine($"{_location} ceiling fan is on low");
        }

        public void Off()
        {
            // turns the ceiling fan off
            _speed = OFF;
            Console.WriteLine($"{_location} ceiling fan is off");
        }
    }
}