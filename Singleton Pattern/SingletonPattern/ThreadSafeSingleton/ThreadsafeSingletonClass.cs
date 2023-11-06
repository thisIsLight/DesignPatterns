using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.ThreadSafeSingleton
{
    public class ThreadsafeSingletonClass
    {
        private static ThreadsafeSingletonClass? Instance;
        private static object lockItem = new();

        private ThreadsafeSingletonClass()
        {
            
        }

        public static ThreadsafeSingletonClass GetInstance()
        {
            if (Instance == null)
            {
                lock (lockItem)
                {
                    Instance = new ThreadsafeSingletonClass();
                }
                return Instance;
            }
            return Instance;
        }
    }
}
