using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.ShapeMaker
{
    public class FacadeShapeMaker
    {
        private readonly Circle circle = new();
        private readonly Square square = new();
        private readonly Rectangle rectangle = new();

        public void DrawCircle()
        {
            circle.Draw();
        }
        public void DrawSquare()
        {
            square.Draw();
        }
        public void DrawRectangle()
        {
            rectangle.Draw();
        }
    }
}
