using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.FaultyObjectClone
{
    [Serializable]
    internal class FaultyPerson
    {
        public string Name { get; set; }
        public FaultyAddress Address { get; set; }

        public FaultyPerson(string name, FaultyAddress address)
        {   
            Name = name;
            Address = address;
        }
    }
}
