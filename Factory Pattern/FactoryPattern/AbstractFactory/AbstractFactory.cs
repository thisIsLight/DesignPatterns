using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractFactory
{
    public static class AbstractFactory
    {
        public static IHotDrink MakeHotDrink(IHotDrinkFactory factory,string name)
        {
            return factory.MakeHotDrink(name);
        }
    }
}
