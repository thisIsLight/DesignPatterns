using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod
{
    public class FactoryMethodPoint
    {
        public double x;
        public double y;

        private FactoryMethodPoint(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static FactoryMethodPoint MakeCartiseanPoint(double x, double y)
        {
            return new FactoryMethodPoint(x, y);
        }

        public static FactoryMethodPoint MakePolarPoint(double con, double theta)
        {
            return new FactoryMethodPoint(con*Math.Cos(theta), con*Math.Sin(theta));
        }
    }
}
