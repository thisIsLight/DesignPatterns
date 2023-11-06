using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Basic_Strategy
{
    public class Cake
    {
        private readonly IMakeCake CakeMethod;
        public Cake(IMakeCake cakeMethod)
        {
            CakeMethod = cakeMethod;
        }
        public void BakeCake()
        {
            CakeMethod.Bake();
        }
    }
}
