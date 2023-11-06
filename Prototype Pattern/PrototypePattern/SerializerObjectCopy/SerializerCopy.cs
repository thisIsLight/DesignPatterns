using PrototypePattern.FaultyObjectClone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.SerializerObjectCopy
{
    public static class SerializerCopy
    {
        public static void Init()
        {
            var john = new FaultyPerson("John", new FaultyAddress("London Road", 123));
            var jane = john.DeepSerializeClone();

            jane.Address.StreetName = "New York Road";

            Console.WriteLine(john.Address.StreetName);
            Console.WriteLine(jane.Address.StreetName);
            Console.WriteLine(john.Address.StreetName != jane.Address.StreetName);
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
