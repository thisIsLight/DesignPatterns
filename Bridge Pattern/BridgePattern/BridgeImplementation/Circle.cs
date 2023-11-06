namespace BridgePattern.BridgeImplementation
{
    public class Circle : Shape
    {
        public int Radius;
        public Circle(int radius, IRenderer render) : base(render)
        {
            Radius = radius;
        }
    }
}