using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.OlderImpementation
{
    public class CircleVectorPrinter
    {
        public void Print(CircleShape circle)
        {
            Console.WriteLine($"Printing Vector Circle: {circle.Name}");
        }
    }
}
