using SingletonPattern.BasicSingleton;
using SingletonPattern.SingletonValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.ThreadSafeSingleton
{
    public class ThreadsafeSingletonInit
    {
        public static void Init()
        {
            var obj1 = ThreadsafeSingletonClass.GetInstance();
            var obj2 = ThreadsafeSingletonClass.GetInstance();

            var ThreadSafe = SingletonValidator<ThreadsafeSingletonClass>.Validate(obj1, obj2);
            Console.WriteLine("ThreadSafe Result :" + ThreadSafe);

            var obj3 = SpinLockClass.GetInstance();
            var obj4 = SpinLockClass.GetInstance();

            var ThreadSafeSpinLock = SingletonValidator<SpinLockClass>.Validate(obj3, obj4);
            Console.WriteLine("ThreadSafeSpinLock Result :" + ThreadSafeSpinLock);

            var obj5 = MutexClass.GetInstance();
            var obj6 = MutexClass.GetInstance();

            var ThreadSafeMutex = SingletonValidator<MutexClass>.Validate(obj5, obj6);
            Console.WriteLine("ThreadSafeMutex Result :" + ThreadSafeMutex);
        }
    }
}
