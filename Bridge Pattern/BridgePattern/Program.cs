using BridgePattern.BridgeImplementation;
using BridgePattern.OlderImpementation;

namespace BridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Older methods for a vector and raster printers would create 4 different service for printing two 
            // types of shapes
            var oldCircle = new CircleShape("Circle1");
            var rasterPrinter = new CircleRasterPrinter();
            rasterPrinter.Print(oldCircle);

            var vectorPrinter = new CircleVectorPrinter();
            vectorPrinter.Print(oldCircle);


            //With new approach
            var rastorInterface = new RasterRenderer();
            var newCircle1 = new Circle(2, rastorInterface);
            newCircle1.Renderer.RenderCircle(newCircle1);

            var vectorInterface = new VectorRenderer();
            var newCircle2 = new Circle(3, vectorInterface);
            newCircle2.Renderer.RenderCircle(newCircle2);
        }
    }
}