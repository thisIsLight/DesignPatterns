using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class ModernPrinterMachine : IMachine
    {
        public void Fax()
        {
            Console.WriteLine("Faxes");
        }

        public void Print()
        {
            Console.WriteLine("Prints");
        }

        public void Scan()
        {
            Console.WriteLine("Scans");
        }
    }
}
