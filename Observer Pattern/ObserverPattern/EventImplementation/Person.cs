using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.EventImplementation
{
    public class Person
    {
        public string Name;
        public Person(string name)
        {
            Name = name;
        }

        public event EventHandler<NameEventArgs> PersonNameChanged;

        public void ChangeName(string ChangedName)
        {
            Name = ChangedName;
            PersonNameChanged?.Invoke(this, new NameEventArgs(this.Name));
        }
    }
}
