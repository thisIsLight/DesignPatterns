using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.LegacyShapes
{
    public class Square
    {
        public int Side;
        public Square(int side) { 
            Side = side;
        }
    }
}
