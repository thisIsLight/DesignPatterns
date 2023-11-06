using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.ProblemScenarioOfPoint
{
    //Here this class takes two inputs and to handle the scenario of Cartesian and Polar points
    //We have to add a switch check in the constructor
    public class BadPoint
    {
        public double x; 
        public double y;

        public BadPoint(double x, double y, string type)
        {
            if (type.Equals("Caretesian"))
            {
                this.x = x;
                this.y = y;
            }
            else
            {
                this.x = x* Math.Cos(y);
                this.y = x*Math.Sin(y);
            }
        }
    }
}
