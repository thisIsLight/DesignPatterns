using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Milk : IToppingsDecorator
    {
        public IBeverages Beverages { get; set; }
        public int Price;

        public Milk(int price, IBeverages beverages)
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
