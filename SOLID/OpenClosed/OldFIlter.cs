using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenClosed.Constants;

namespace OpenClosed
{
    public class OldFIlter
    {
        public static IEnumerable<Product> FilterProductByColor(IEnumerable<Product> products, Color color)
        {
            foreach (Product product in products)
            {
                if(product.Color == color)
                yield return product;
            }
        }
        public static IEnumerable<Product> FilterProductBySize(IEnumerable<Product> products, Size size)
        {
            foreach (Product product in products)
            {
                if (product.Size == size)
                    yield return product;
            }
        }
        public static IEnumerable<Product> FilterProductByColorAndSize(IEnumerable<Product> products, Color color, Size size)
        {
            foreach (Product product in products)
            {
                if (product.Color == color && product.Size == size)
                    yield return product;
            }
        }
    }
}
