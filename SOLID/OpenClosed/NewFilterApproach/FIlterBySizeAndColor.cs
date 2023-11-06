using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.NewFilterApproach
{
    public class FIlterBySizeAndColor : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> t, ISpecification<Product> specification)
        {
            foreach (Product p in t)
            {
                if (specification.IsValid(p))
                {
                    yield return p;
                }
            }
        }
    }
}
