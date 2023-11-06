using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.SingletonValidator
{
    public static class SingletonValidator<T>
    {
        public static bool Validate(T t1, T t2)
        {
            if(t1.Equals(t2))
            {
                return true;
            }
            return false;
        }
    }
}
