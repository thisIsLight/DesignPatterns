using SingletonPattern.BasicSingleton;
using SingletonPattern.ThreadSafeSingleton;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //What is a songleton ?
            //WHenever we want to have access to a particualr resource by ine way only
            //This is mainly for data consistency

            //Normal Singleton
            BasicSingletonInit.Init();

            //TreadSafe Singletons
            ThreadsafeSingletonInit.Init();
        }
    }
}