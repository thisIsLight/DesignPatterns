using StrategyPattern.Basic_Strategy;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //we want to make cake.
            var method = new RussianStyle();
            var cake = new Cake(method);
            cake.BakeCake();
        }
    }
}