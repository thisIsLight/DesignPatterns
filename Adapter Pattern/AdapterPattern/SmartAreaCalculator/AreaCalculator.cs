using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.SmartAreaCalculator
{
    public static class AreaCalculator
    {
        public static int Area(IRectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }
    }
}
