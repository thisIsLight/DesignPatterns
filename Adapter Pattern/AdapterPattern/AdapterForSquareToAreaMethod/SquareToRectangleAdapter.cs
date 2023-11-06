using AdapterPattern.LegacyShapes;
using AdapterPattern.SmartAreaCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.AdapterForSquareToAreaMethod
{
    public class SquareToRectangleAdapter : IRectangle
    {
        private int width;
        private int height;
        public int Height
        {
            get => height;
            set => height = value;
        }

        public int Width
        {
            get => width;
            set => width = value;
        }

        public SquareToRectangleAdapter(Square square)
        {
            width = square.Side;
            height = square.Side;
        }
    }
}
