using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern.Log
{
    public class ConsoleLog : ILog
    {
        public void Info()
        {
            Console.WriteLine("Inserting log on console");
        }
    }
}
