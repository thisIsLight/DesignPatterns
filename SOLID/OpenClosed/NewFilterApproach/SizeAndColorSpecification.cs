using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenClosed.Constants;

namespace OpenClosed.NewFilterApproach
{
    public class SizeAndColorSpecification : ICombinedSpecification<Product>
    {
        #region Properties
        private readonly Size Size;
        private readonly Color Color;
        #endregion

        #region ctor
        public SizeAndColorSpecification(Size size, Color color)
        {
            Size = size;
            Color = color;
        }
        #endregion

        public bool IsValid(Product t)
        {
            return t.Size.Equals(Size) && t.Color.Equals(Color);
        }
    }
}
