using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory
{
    public static class PointFactory
    {
        public static Point CreateCartiseanPoint(double x, double y)
        {
            return new Point(x, y);
        }
        public static Point CreatePolarPoint(double con, double theta)
        {
            return new Point(con * Math.Cos(theta), con * Math.Sin(theta));
        }
    }
}
