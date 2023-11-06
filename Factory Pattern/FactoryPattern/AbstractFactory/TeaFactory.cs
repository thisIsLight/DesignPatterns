using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractFactory
{
    public class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink MakeHotDrink(string Name)
        {
            return new Tea(Name);
        }
    }
}
