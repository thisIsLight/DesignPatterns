using PrototypePattern.FaultyObjectClone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.CloneableObjectCopy
{
    internal static class CloneableCopy
    {
        public static void Init()
        {
            var john = new CloneablePerson("John", new CloneableAddress("London Road", 123));

            //Here we are cloning and converting the type to the required type
            var jane = (CloneablePerson)john.Clone();

            jane.Address.StreetName = "New York Road";

            Console.WriteLine(john.Address.StreetName);
            Console.WriteLine(jane.Address.StreetName);
            Console.WriteLine(john.Address.StreetName != jane.Address.StreetName);
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
