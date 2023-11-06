using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.BridgeImplementation
{
    public class Shape
    {
        public IRenderer Renderer;
        public Shape(IRenderer render)
        {
            Renderer = render;
        }
    }
}
