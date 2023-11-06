using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.OlderImpementation
{
    public class CircleShape : IShape
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public CircleShape(string name)
        {
            this.name = name;
        }
    }
}
