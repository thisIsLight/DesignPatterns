using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.NewFilterApproach
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> t, ISpecification<T> specification);
    }
}
