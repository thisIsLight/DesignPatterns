using PrototypePattern.CustomInterfaceObjectClone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PrototypePattern.GenericInterfaceObjectCopy
{
    internal class GenericInterfaceEmployee : GenericInterfacePerson, IGenericCloneable<GenericInterfaceEmployee>
    {
        public int Salary;

        public GenericInterfaceEmployee(int salary, string name, GeneriInterfaceAddress address) : base(name, address)
        {
            Salary = salary;
        }
        public GenericInterfaceEmployee()
        {
            
        }

        public void CopyTo(GenericInterfaceEmployee target)
        {
            base.CopyTo(target);
            target.Salary = Salary;
        }
    }
}
