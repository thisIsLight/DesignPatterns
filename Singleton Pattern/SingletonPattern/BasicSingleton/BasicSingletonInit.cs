using SingletonPattern.SingletonValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.BasicSingleton
{
    public class BasicSingletonInit
    {
        public static void Init()
        {
            var obj1 = BasicSingletonClass.GetInstance();
            var obj2 = BasicSingletonClass.GetInstance();

            var declarativeResult = SingletonValidator<BasicSingletonClass>.Validate(obj1, obj2);
            Console.WriteLine("Decalarative Result :" + declarativeResult);


            var obj3 = BasicSingletonClassWithLazyLoad.GetInstance();
            var obj4 = BasicSingletonClassWithLazyLoad.GetInstance();

            var lazyResult = SingletonValidator<BasicSingletonClassWithLazyLoad>.Validate(obj3, obj4);
            Console.WriteLine("LazyResult Result :" + lazyResult);

        }
    }
}
