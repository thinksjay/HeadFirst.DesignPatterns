using System;

namespace HeadFirst.DesignPatterns.TemplateMethod
{
    public class TeaWithHook : CaffeineBeverageWithHook
    {
        
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();

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
            // get the user's response
            string answer = null;

            Console.WriteLine("Would you like lemon with your tea (y/n)? ");

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