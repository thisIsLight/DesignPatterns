using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.ThreadSafeSingleton
{
    public class SpinLockClass
    {
        private static SpinLockClass? Instance;
        private static SpinLock spinLock = new();
        private static bool lockTaken = false;

        private SpinLockClass()
        {

        }

        public static SpinLockClass GetInstance()
        {
            if (Instance == null)
            {
                try
                {
                    spinLock.TryEnter(ref lockTaken);
                    if (lockTaken)
                    {
                        Instance = new SpinLockClass();
                        return Instance;
                    }
                }
                catch
                {
                    throw;
                }
                finally {
                    if (lockTaken)
                    {
                        spinLock.Exit();
                    }
                }
            }
            return Instance;
        }
    }
}
