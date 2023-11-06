using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.GenericInterfaceObjectCopy
{
    public interface IGenericCloneable<T> where T : new()
    {
        void CopyTo(T target);
        T DeepCopy()
        {
            var t = new T();
            CopyTo(t);
            return t;
        }
    }
}
