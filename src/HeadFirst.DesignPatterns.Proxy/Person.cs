using System;

namespace HeadFirst.DesignPatterns.Proxy

{

    public class Person : IPerson
    {

        private string name;

        private string gender;

        private string interest;

        private int rating;

        private int ratingCount = 0;


        public Person()
        { }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }



        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }


        public string Interest
        {
            get
            {
                return interest;
            }
            set
            {
                interest = value;
            }
        }

        public int HotOrNot
        {
            get
            {
                if (ratingCount == 0)
                {
                    return 0;
                }
                else
                {
                    return rating / ratingCount;
                }
            }
            set
            {
                rating += value;
                ratingCount++;
            }
        }
    }

}