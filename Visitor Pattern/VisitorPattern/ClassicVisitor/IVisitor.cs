﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.ClassicVisitor
{
    public interface IVisitor
    {
        void Visit(DoubleExpression exp);
        void Visit(AdditionExpression exp);
    }
}
