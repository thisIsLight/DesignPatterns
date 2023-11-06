using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.BasicBuilderPattern
{
    public class FacetPersonBuilder
    {
        protected Person Person = new Person();

        public AddressBuilder Lives => new AddressBuilder(Person);
        public WorkProfileBuilder Works => new WorkProfileBuilder(Person);

    }
}
