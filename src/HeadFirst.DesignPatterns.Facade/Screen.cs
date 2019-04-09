using System;

namespace HeadFirst.DesignPatterns.Facade
{
    public class Screen
    {
        private string _description;

        public Screen(string description)
        {
            _description = description;
        }

        public void Up()
        {
            Console.WriteLine($"{_description} going up");
        }

        public void Down()
        {
            Console.WriteLine($"{_description} going down");
        }

        public override string ToString()
        {
            return _description;
        }
    }
}