using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class ScannerMachine : IScanner
    {
        public void Scan()
        {
            Console.WriteLine("Scans 1");
        }
    }
}
