using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.OlderImpementation
{
    public class CircleRasterPrinter
    {
        public void Print(CircleShape circle) {
            Console.WriteLine($"Printing Raster Circle: {circle.Name}");
        }
    }
}
