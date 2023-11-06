using PrototypePattern.CloneableObjectCopy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace PrototypePattern.GenericInterfaceObjectCopy
{
    internal class GeneriInterfaceAddress : IGenericCloneable<GeneriInterfaceAddress>
    {
        public string StreetName { get; set; } = string.Empty;
        public int HouseNumber { get; set; }

        public GeneriInterfaceAddress(string streetName, int houseNumber)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
        }
        public GeneriInterfaceAddress()
        {
            
        }

        public void CopyTo(GeneriInterfaceAddress target)
        {
            target.StreetName = StreetName;
            target.HouseNumber = HouseNumber;
        }
    }
}
