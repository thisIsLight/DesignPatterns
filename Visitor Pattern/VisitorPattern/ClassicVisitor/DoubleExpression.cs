using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.ClassicVisitor
{
    public class DoubleExpression : IExpression
    {
        public int Value { get; set; }

        public DoubleExpression(int value)
        {
            Value = value;
        }

        public void Action(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
