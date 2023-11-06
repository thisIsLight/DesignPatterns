using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.NewFilterApproach
{
    public interface ISpecification<T>
    {
        bool IsValid(T t);
    }
}
