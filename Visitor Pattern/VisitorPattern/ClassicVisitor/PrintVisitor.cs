using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.ClassicVisitor
{
    internal class PrintVisitor : IVisitor
    {
        public StringBuilder sb = new StringBuilder();
        public void Visit(DoubleExpression exp)
        {
            sb.Append(exp.Value);
        }

        public void Visit(AdditionExpression exp)
        {
            sb.Append('(');
            exp.Expression1.Action(this);
            sb.Append('+');
            exp.Expression2.Action(this);
            sb.Append(')');
        }
    }
}
