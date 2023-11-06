using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.ClassicVisitor
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
        public void Action(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
