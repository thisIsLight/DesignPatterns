using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.BasicBuilderPattern
{
    public class Person
    {
        public string Name{ get; set; }
        public string Company { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int AddressLineZipCode { get; set; }

        public override string ToString()
        {
            return "The ToStringConversion of Person";
        }

    }
}
