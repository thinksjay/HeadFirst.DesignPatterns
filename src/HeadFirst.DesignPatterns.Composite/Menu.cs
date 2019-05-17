using System.Collections;
using System;

namespace HeadFirst.DesignPatterns.Composite
{
    public class Menu:MenuComponent
    {
        private readonly ArrayList _menuComponents;
        private readonly string _name;
        private readonly string _description;

        public Menu(string name,string description)
        {
            _name=name;
            _description=description;
            _menuComponents=new ArrayList();
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return _menuComponents[i] as MenuComponent;
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override void Print()
        {
            Console.Write($"{Environment.NewLine}{_name}");
            Console.Write($", {_description}");
            Console.WriteLine("------------------");

            foreach(MenuComponent  menuComponent in _menuComponents)
            {
                menuComponent.Print();
            }
        }
    }
}