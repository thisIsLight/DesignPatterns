using PrototypePattern.FaultyObjectClone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.ConstructorObjectCopy
{
    internal static class ConstructorCopy
    {
        public static void Init()
        {
            var john = new ConstructorCopyPerson("John", new ConstructorCopyAddress("London Road", 123));
            var jane = new ConstructorCopyPerson(john);

            jane.Address.StreetName = "New York Road";

            Console.WriteLine(john.Address.StreetName);
            Console.WriteLine(jane.Address.StreetName);
            Console.WriteLine(john.Address.StreetName != jane.Address.StreetName);
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
