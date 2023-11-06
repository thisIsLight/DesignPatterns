using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Coffee : IBeverages
    {
        private int Price;
        public Coffee(int price)
        {
            Price = price;
        }
        public int Cost()
        {
            return Price;
        }
    }
}
