using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.IntrusiveImplementation
{
    public class AdditionExpression : IExpression
    {
        public IExpression Expression1 { get; set; }
        public IExpression Expression2 { get; set; }

        public AdditionExpression(IExpression exp1, IExpression exp2)
        {
            Expression1 = exp1;
            Expression2 = exp2;
        }

        public void Print(StringBuilder sb)
        {
            sb.Append('(');
            Expression1.Print(sb);
            sb.Append('+');
            Expression2.Print(sb);
            sb.Append(')');
        }
    }
}
