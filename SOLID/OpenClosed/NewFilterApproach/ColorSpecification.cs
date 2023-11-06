using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenClosed.Constants;

namespace OpenClosed.NewFilterApproach
{
    internal class ColorSpecification : ISpecification<Product>
    {
        #region Properties
        private readonly Color Color;
        #endregion

        #region ctor
        public ColorSpecification(Color color)
        {
            Color = color;
        }
        #endregion

        #region Public method
        public bool IsValid(Product t)
        {
            return t.Color.Equals(Color);
        }
        #endregion
    }
}
