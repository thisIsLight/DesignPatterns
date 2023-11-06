using PrototypePattern.CustomInterfaceObjectClone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.GenericInterfaceObjectCopy
{
    public static class GenericInterfaceCopy
    {
        public static void Init()
        {
            var john = new GenericInterfaceEmployee(123000, "John", new GeneriInterfaceAddress("London Road", 123));

            //Here we are cloning and converting the type to the required type
            var jane = ((IGenericCloneable<GenericInterfaceEmployee>)john).DeepCopy();

            jane.Address.StreetName = "New York Road";

            Console.WriteLine(john.Address.StreetName);
            Console.WriteLine(jane.Address.StreetName);
            Console.WriteLine(john.Address.StreetName != jane.Address.StreetName);
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
