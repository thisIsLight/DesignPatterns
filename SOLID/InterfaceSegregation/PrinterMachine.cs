﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class PrinterMachine : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Prints 1");
        }
    }
}
