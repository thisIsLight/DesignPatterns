using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.BridgeImplementation
{
    public class RasterRenderer : IRenderer
    {
        public void RenderCircle(Circle circle)
        {
            Console.WriteLine($"Rendering a Raster circle with radius {circle.Radius}");
        }
    }
}
