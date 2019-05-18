using System;
namespace HeadFirst.DesignPatterns.Combining
{
    public class Goose
    {
        public void Honk()
        {
            Console.WriteLine("Honk");
        }

        public override string ToString()
        {
            return "Goose";
        }
    }
}