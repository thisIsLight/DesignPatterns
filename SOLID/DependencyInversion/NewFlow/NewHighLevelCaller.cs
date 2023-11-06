using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DependencyInversion.NewFlow
{
    public class NewHighLevelCaller
    {
        private readonly ILowLevelServiceProvider _lowLevelServiceProvider;

        public NewHighLevelCaller(ILowLevelServiceProvider lowLevelServiceProvider)
        {
            _lowLevelServiceProvider = lowLevelServiceProvider;
        }
        public void Call()
        {
            Console.WriteLine("New High level caller called!");
            _lowLevelServiceProvider.SomeServiceFromLowLevelToBeServed();
        }
    }
}
