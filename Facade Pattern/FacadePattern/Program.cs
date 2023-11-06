using FacadePattern.ShapeMaker;

namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Only using the facade here

            var shapeMaker = new FacadeShapeMaker();
            shapeMaker.DrawCircle();
            shapeMaker.DrawSquare();
            shapeMaker.DrawRectangle();
        }
    }
}