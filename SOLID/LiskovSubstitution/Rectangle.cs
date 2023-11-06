using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Rectangle(int width = 0, int height = 0)
        {
            Width = width;
            Height = height;
        }

        public int Area()
        {
            return Width*Height;
        }
    }
}
