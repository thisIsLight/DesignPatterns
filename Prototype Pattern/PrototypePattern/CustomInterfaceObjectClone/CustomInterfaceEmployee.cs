using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.CustomInterfaceObjectClone
{
    public class CustomInterfaceEmployee : CustomInterfacePerson, IDeepCloneable<CustomInterfaceEmployee>
    {
        public int Salary;

        public CustomInterfaceEmployee(int salary, string name, CustomInterfaceAddress address) : base(name ,address)
        {
            Salary = salary;
        }

        CustomInterfaceEmployee IDeepCloneable<CustomInterfaceEmployee>.Clone()
        {
            return new CustomInterfaceEmployee(Salary, Name, Address.Clone());
        }
    }
}
