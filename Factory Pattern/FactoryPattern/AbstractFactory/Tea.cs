using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractFactory
{
    internal class Tea : IHotDrink
    {
        public string Name { get; set; }

        public Tea(string drinkName)
        {
            Name = drinkName;
        }
        public void Consume()
        {
            Console.WriteLine("What a nice Tea!");
        }
    }
}
