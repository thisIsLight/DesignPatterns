using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractFactory
{
    public class Coffee : IHotDrink
    {
        public string Name { get; set; }

        public Coffee(string drinkName)
        {
            Name = drinkName;
        }

        public void Consume()
        {
            Console.WriteLine("What a string Coffee!");
        }
    }
}
