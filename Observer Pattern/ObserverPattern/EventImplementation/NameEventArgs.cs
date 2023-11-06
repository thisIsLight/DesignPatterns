using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.EventImplementation
{
    public class NameEventArgs : EventArgs
    {
        public string Name;
        public NameEventArgs(string name)
        {
            Name = name;
        }
    }
}
