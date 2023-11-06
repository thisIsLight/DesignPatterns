using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.OldPattern
{
    public class PersonClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Company { get; set; } 

        public PersonClass(string Name, int Age, string Company) { 
            this.Name = Name ?? string.Empty;
            this.Age = Age;
            this.Company = Company ?? string.Empty;
        }
        public override string ToString()
        {
            return this.Name+this.Age+this.Company;
        }
    }
}
