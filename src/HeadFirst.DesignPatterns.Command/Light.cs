using System;

namespace HeadFirst.DesignPatterns.Command
{
    public class Light
    {
        private string _location;
        private int _level;

        public int Level { get { return _level; } }
        public Light(string location)
        {
            _location = location;
        }

        public void On()
        {
            _level = 100;
            Console.WriteLine("Light is on");
        }

        public void Off()
        {
            _level = 0;
            Console.WriteLine("Light is off");
        }

        public void Dim(int level)
        {
            _level = level;
            if (level == 0)
            {
                Off();
            }
            else
            {
                Console.WriteLine("Light is dimmed to {level}%");
            }
        }
    }
}