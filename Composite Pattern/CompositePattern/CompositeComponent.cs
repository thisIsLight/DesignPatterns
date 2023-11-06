using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class CompositeComponent : IComponent
    {
        public string Name;
        public List<IComponent> components = new();

        public CompositeComponent(string name)
        {
            Name = name;
        }

        public void AddComponents(IComponent component)
        {
            components.Add(component);
        }

        public void ShowPrice()
        {
            Console.WriteLine($"{Name} :");
            foreach (IComponent component in components)
            {
                component.ShowPrice();
            }
        }
    }
}
