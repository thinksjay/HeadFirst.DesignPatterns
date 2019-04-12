namespace HeadFirst.DesignPatterns.Iterator
{
    public class MenuItem
    {
        public string Name
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }

        public bool IsVegetarian
        {
            get;
            set;
        }
        public double Price
        {
            get;
            set;
        }
        public MenuItem(string name,

            string description,

            bool isVegetarian,

            double price)

        {
            Name = name;

            Description = description;

            IsVegetarian = isVegetarian;

            Price = price;
        }

    }
}