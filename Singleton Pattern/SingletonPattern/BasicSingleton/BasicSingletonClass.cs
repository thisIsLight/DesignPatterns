namespace SingletonPattern.BasicSingleton
{
    public class BasicSingletonClass
    {
        private readonly static BasicSingletonClass instance = new();
        private BasicSingletonClass()
        {
        }
        public static BasicSingletonClass GetInstance()
        {
            return instance;
        }
    }

    public class BasicSingletonClassWithLazyLoad
    {
        private static BasicSingletonClassWithLazyLoad? instance;
        private BasicSingletonClassWithLazyLoad()
        {
        }
        public static BasicSingletonClassWithLazyLoad GetInstance()
        {
            if (instance == null)
            {
                instance = new BasicSingletonClassWithLazyLoad();
            }
            return instance;
        }
    }
}