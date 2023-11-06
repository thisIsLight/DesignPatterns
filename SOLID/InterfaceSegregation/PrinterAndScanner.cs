using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class PrinterAndScanner : IPrinterScannerMachine
    {
        public void Print()
        {
            Console.WriteLine("Prints 2");
        }

        public void Scan()
        {
            Console.WriteLine("Scans 2");
        }
    }
}
