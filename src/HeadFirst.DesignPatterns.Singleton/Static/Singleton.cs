namespace HeadFirst.DesignPatterns.Singleton.Static
{
    public class Singleton
    {
        private readonly static Singleton _instance=new Singleton();
        private Singleton(){}

        public static Singleton GetInstance()
        {
            return _instance;
        }
    }
}