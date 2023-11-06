using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.GenericInterfaceObjectCopy
{
    internal class GenericInterfacePerson : IGenericCloneable<GenericInterfacePerson>
    {
        public string Name { get; set; } = string.Empty;
        public GeneriInterfaceAddress Address { get; set; } = new GeneriInterfaceAddress();

        public GenericInterfacePerson(string name, GeneriInterfaceAddress address)
        {
            Name = name;
            Address = address;
        }
        public GenericInterfacePerson()
        {
            
        }

        public void CopyTo(GenericInterfacePerson target)
        {
            target.Name = Name;
            target.Address = ((IGenericCloneable<GeneriInterfaceAddress>)Address).DeepCopy();
        }
    }
}
