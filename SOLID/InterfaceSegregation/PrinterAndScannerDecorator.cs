using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class PrinterAndScannerDecorator : IPrinterScannerMachine
    {
        private readonly IPrinter Printer;
        private readonly IScanner Scanner;

        public PrinterAndScannerDecorator(IPrinter printer, IScanner scanner)
        {
            Printer = printer;
            Scanner = scanner;
        }
        public void Print()
        {
            Printer.Print();
        }

        public void Scan()
        {
            Scanner.Scan();
        }
    }
}
