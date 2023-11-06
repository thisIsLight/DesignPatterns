using PrototypePattern.CloneableObjectCopy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.CustomInterfaceObjectClone
{
    public static class CustomInterfaceCopy
    {
        public static void Init()
        {
            var john = new CustomInterfacePerson("John", new CustomInterfaceAddress("London Road", 123));

            //Here we are cloning and converting the type to the required type
            var jane = john.Clone();

            jane.Address.StreetName = "New York Road";

            Console.WriteLine(john.Address.StreetName);
            Console.WriteLine(jane.Address.StreetName);
            Console.WriteLine(john.Address.StreetName != jane.Address.StreetName);
            Console.WriteLine("-----------------------------------------------");
        }

        public static void InitInheritance()
        {
            var john = new CustomInterfaceEmployee(123000,"John", new CustomInterfaceAddress("London Road", 123));

            //Here we are cloning and converting the type to the required type
            var jane = john.Clone();

            jane.Address.StreetName = "New York Road";

            Console.WriteLine(john.Address.StreetName);
            Console.WriteLine(jane.Address.StreetName);
            Console.WriteLine(john.Address.StreetName != jane.Address.StreetName);
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
