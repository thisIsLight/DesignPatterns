using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.ThreadSafeSingleton
{
    internal class MutexClass
    {
        private static MutexClass? Instance;
        private static readonly Mutex mutex = new();
        private static bool lockTaken = false;

        private MutexClass()
        {

        }

        public static MutexClass GetInstance()
        {
            if (Instance == null)
            {
                lockTaken = mutex.WaitOne();
                if (lockTaken)
                {
                    Instance = new MutexClass();
                    mutex.ReleaseMutex();
                    return Instance;
                }
            }
            return Instance;
        }
    }
}
