using PrototypePattern.FaultyObjectClone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.CloneableObjectCopy
{
    internal class CloneablePerson : ICloneable
    {
        public string Name { get; set; }
        public CloneableAddress Address { get; set; }

        public CloneablePerson(string name, CloneableAddress address)
        {
            Name = name;
            Address = address;
        }
        public object Clone()
        {
            return new CloneablePerson(Name, (CloneableAddress) Address.Clone());
        }
    }
}
