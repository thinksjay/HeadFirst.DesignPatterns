using System;

namespace HeadFirst.DesignPatterns.Command
{
    public class TV
    {
        private readonly string _location;
        private int _channel;

        public TV(string location)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine($"{_location} TV is on");
        }

        public void Off()
        {
            Console.WriteLine($"{_location} TV is off");
        }

        public void SetInputChannel()
        {
            _channel = 3;
            Console.WriteLine($"{_location} TV channel{_channel} is set for DVD");
        }
    }
}