using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class LeafComponent : IComponent
    {
        public string Name;
        public int Price;
        public LeafComponent(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public void ShowPrice()
        {
            Console.WriteLine($"{Name} : {Price}");
        }
    }
}
