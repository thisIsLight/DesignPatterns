using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.FaultyObjectClone
{
    public static class FaultyCopy
    {
        public static void Init()
        {
            var john = new FaultyPerson("John", new FaultyAddress("London Road", 123));
            var jane = john;

            jane.Address.StreetName = "New York Road";

            Console.WriteLine(john.Address.StreetName);
            Console.WriteLine(jane.Address.StreetName);
            Console.WriteLine(john.Address.StreetName != jane.Address.StreetName);
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
