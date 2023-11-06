using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenClosed.Constants;

namespace OpenClosed.NewFilterApproach
{
    public class SizeSpecification : ISpecification<Product>
    {
        #region Properties
        private readonly Size Size;
        #endregion

        #region ctor
        public SizeSpecification(Size size)
        {
            Size = size;
        }
        #endregion

        #region Public methods
        public bool IsValid(Product t)
        {
            return t.Size.Equals(Size);
        }
        #endregion
    }
}
