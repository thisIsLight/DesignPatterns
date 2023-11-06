using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.EventImplementation
{
    public class AadharSystem
    {
        public Person Person;
        public AadharSystem(Person person) {
            Person = person;
            Person.PersonNameChanged += PersonNameChangedHandler;
        }

        private static void PersonNameChangedHandler(object person, NameEventArgs args)
        {
            Console.WriteLine($"Name changed {args.Name}");
        }
    }
}
