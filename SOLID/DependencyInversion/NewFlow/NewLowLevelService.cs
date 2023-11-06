using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.NewFlow
{
    public class NewLowLevelService : ILowLevelServiceProvider
    {
        public void SomeServiceFromLowLevelToBeServed()
        {
            Console.WriteLine("New Low level service responded !");
        }
    }
}
