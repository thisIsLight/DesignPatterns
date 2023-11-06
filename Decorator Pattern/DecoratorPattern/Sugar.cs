using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class Sugar : IToppingsDecorator
    {
        public IBeverages Beverages { get; set; }
        public int Price;

        public Sugar(int price, IBeverages beverages)
        {
            Beverages = beverages;
            Price = price;
        }

        public int Cost()
        {
            return Price + Beverages.Cost();
        }
    }
}
