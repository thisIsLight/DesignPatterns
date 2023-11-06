using System.Text;
using VisitorPattern.ClassicVisitor;
using VisitorPattern.IntrusiveImplementation;

namespace VisitorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intrusive Implementation
            var exp = new IntrusiveImplementation.AdditionExpression(new IntrusiveImplementation.DoubleExpression(1), new IntrusiveImplementation.DoubleExpression(2));
            var sb = new StringBuilder();
            exp.Print(sb);
            Console.WriteLine(sb.ToString());

            //Classic Visitor
            var printVisitor = new PrintVisitor();
            var expNew = new ClassicVisitor.AdditionExpression(new ClassicVisitor.DoubleExpression(1), new ClassicVisitor.DoubleExpression(2));
            expNew.Action(printVisitor);
            Console.WriteLine(printVisitor.sb.ToString());

        }
    }
}