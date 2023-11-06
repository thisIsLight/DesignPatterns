using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.BasicBuilderPattern
{
    public class AddressBuilder : FacetPersonBuilder
    {
        public AddressBuilder(Person person)
        {
            this.Person = person;
        }
        public AddressBuilder AddAddress1(string address1)
        {
            this.Person.AddressLine1 = address1;
            return this;
        }
        public AddressBuilder AddZipCode(int zipcode)
        {
            this.Person.AddressLineZipCode = zipcode;
            return this;
        }
        public AddressBuilder AddAddress2(string address2)
        {
            this.Person.AddressLine2 = address2;
            return this;
        }
    }
}
