using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Tea : IBeverages
    {
        public int Price;
        public Tea(int price)
        {
            Price = price;
        }
        public int Cost()
        {
            return Price;
        }
    }
}
