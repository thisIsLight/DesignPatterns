﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IMachine
    {
        void Print();
        void Fax();
        void Scan();
    }
}
