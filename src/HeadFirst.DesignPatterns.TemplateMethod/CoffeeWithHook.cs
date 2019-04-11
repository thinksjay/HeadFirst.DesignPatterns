using System;

namespace HeadFirst.DesignPatterns.TemplateMethod
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {

        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override bool CustomerWantsCondiments()
        {

            String answer = GetUserInput();

            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetUserInput()
        {
            string answer = null;

            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");

            try
            {
                answer = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("IO error trying to read your answer");
            }
            if (answer == null)
            {
                return "no";
            }
            return answer;
        }
    }
}