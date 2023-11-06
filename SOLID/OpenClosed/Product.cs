using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenClosed.Constants;

namespace OpenClosed
{
    public class Product
    {
        #region Properties
        public string Name { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
        #endregion

        #region ctor
        public Product(string name, Color color, Size size)
        {
            Name = name ?? throw new NullReferenceException(); 
            Color = color; 
            Size = size;
        }

        public override string ToString()
        {
            return Name+" "+Color.ToString()+" "+Size.ToString();
        }
        #endregion
    }
}
