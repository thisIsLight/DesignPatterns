using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class OldPrinterMachine : IMachine
    {
        public void Fax()
        {
            Console.WriteLine("Faxes");
        }

        public void Print()
        {
            Console.WriteLine("Prints");
        }

        //This machine doesn't scan since its an old machine so we have to throw an exception for this or return an error
        public void Scan()
        {
            throw new NotImplementedException("Doesn't have this functionality since its old");
        }
    }
}
