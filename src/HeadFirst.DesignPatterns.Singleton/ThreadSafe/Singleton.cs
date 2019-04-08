
namespace HeadFirst.DesignPatterns.Singleton.ThreadSafe
{
    public class Singleton
    {
        private static Singleton _instance;
        private static object lockObj=new object();
        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if(_instance==null)
            {
                lock(lockObj)
                {
                    if(_instance==null)
                    {
                        _instance=new Singleton();
                    }
                }
            }
            return _instance;
        }
    }
}