using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class RussianStyle : IMakeCake
    {
        public void Bake()
        {
            Console.WriteLine("Baking a cake in Russing method");
        }
    }
}
