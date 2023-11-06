using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.BasicBuilderPattern
{
    public class WorkProfileBuilder : FacetPersonBuilder
    {
        public WorkProfileBuilder(Person person)
        {
            this.Person = person;
        }
        public WorkProfileBuilder WorksAt(string company)
        {
            this.Person.Company = company;
            return this;
        }
        public WorkProfileBuilder Earns(int salary)
        {
            this.Person.Salary = salary;
            return this;
        }
        public WorkProfileBuilder WorksAs(string designation)
        {
            this.Person.Designation = designation;
            return this;
        }
    }
}
