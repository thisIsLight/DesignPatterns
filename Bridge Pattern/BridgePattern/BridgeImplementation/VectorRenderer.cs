using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.BridgeImplementation
{
    public class VectorRenderer : IRenderer
    {
        public void RenderCircle(Circle circle)
        {
            Console.WriteLine($"Rendering a Vector circle with radius {circle.Radius}");
        }
    }
}
