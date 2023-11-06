using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.OldFlow
{
    public class HigherLevelCaller
    {
        public void Call()
        {
            Console.WriteLine("High level caller called!");
            var serviceInstance = new LowLevelService();
            serviceInstance.CalledService();
        }
    }
}
