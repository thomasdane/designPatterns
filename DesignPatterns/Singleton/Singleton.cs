
namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        private static Singleton _firstInstance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (_firstInstance == null)
            {
                _firstInstance = new Singleton();
            }

            return _firstInstance;
        }
    }
}
