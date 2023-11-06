using FactoryPattern.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.InnerFactory
{
    public class InnerFactoryPoint
    {
        public double x;
        public double y;

        private InnerFactoryPoint(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static class Factory
        {
            public static InnerFactoryPoint CreateCartiseanPoint(double x, double y)
            {
                return new InnerFactoryPoint(x, y);
            }
            public static InnerFactoryPoint CreatePolarPoint(double con, double theta)
            {
                return new InnerFactoryPoint(con * Math.Cos(theta), con * Math.Sin(theta));
            }
        }

    }
}
