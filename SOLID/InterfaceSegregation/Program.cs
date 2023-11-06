namespace InterfaceSegregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Basically instead of making a single interface, better to make more than one interface

            //With Single interface
            var newMachine = new ModernPrinterMachine();
            var oldMachine = new OldPrinterMachine();

            //If I try to access old Machine scanning feature
            try
            {
                oldMachine.Scan();
            }
            catch(Exception e) {
                Console.Write("Error trhown : "+e.Message);
            }

            //With new implementation : 
            //We create separate interfaces for all the functionalities
            var printer = new PrinterMachine();
            var scanner = new ScannerMachine();

            var printerAndScanner = new PrinterAndScanner();
            var printerAndScannerDecorator = new PrinterAndScannerDecorator(printer,scanner);

            printer.Print();
            scanner.Scan();
            printerAndScanner.Print();
            printerAndScanner.Scan();
            printerAndScannerDecorator.Print();
            printerAndScannerDecorator.Scan();

        }
    }
}