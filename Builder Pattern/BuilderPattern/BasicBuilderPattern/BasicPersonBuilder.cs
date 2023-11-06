using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.BasicBuilderPattern
{
    public class BasicPersonBuilder
    {
        private Person person = new Person();

        public BasicPersonBuilder Named(string name)
        {
            person.Name = name;
            return this;
        }
        public BasicPersonBuilder WorksAt(string company)
        {
            person.Company = company;
            return this;
        }
        public BasicPersonBuilder Earns(int salary)
        {
            person.Salary = salary;
            return this;
        }
        public BasicPersonBuilder WorksAs(string designation)
        {
            person.Designation = designation;
            return this;
        }
    }
}
