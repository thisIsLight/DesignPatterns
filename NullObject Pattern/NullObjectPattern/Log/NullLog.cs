using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern.Log
{
    public class NullLog : ILog
    {
        private readonly static ILog Instance = new NullLog();
        public static ILog GetInstance() => Instance;
        private NullLog()
        {
            
        }
        public void Info()
        {
            Console.WriteLine("Logging in a null logger");
        }
    }
}
