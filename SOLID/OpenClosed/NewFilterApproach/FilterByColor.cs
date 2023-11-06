using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.NewFilterApproach
{
    public class FilterByColor : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> t, ISpecification<Product> specification)
        {
            foreach(var product in t)
            {
                if (specification.IsValid(product))
                {
                    yield return product;
                }
            }
        }
    }
}
