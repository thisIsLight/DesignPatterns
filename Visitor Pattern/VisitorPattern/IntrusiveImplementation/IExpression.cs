using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.IntrusiveImplementation
{
    public interface IExpression
    {
        void Print(StringBuilder sb);
    }
}
