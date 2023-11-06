using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.ShapeMaker
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }
}
