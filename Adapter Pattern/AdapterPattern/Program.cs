using AdapterPattern.AdapterForSquareToAreaMethod;
using AdapterPattern.LegacyShapes;
using AdapterPattern.SmartAreaCalculator;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Say we had legacy created squares
            var sq1 = new Square(2);

            //We want to use the new Method but it needs the IRectangle type of input
            //Hence we use our adapter to convert our current square to a IRectangle decedent
            var convertedSq1 = new SquareToRectangleAdapter(sq1);

            //Now we have the new type available which can be directly fed to the area service
            var area = AreaCalculator.Area(convertedSq1);
            Console.WriteLine($"Area of a square with side {sq1.Side} is : {area}");
        }
    }
}