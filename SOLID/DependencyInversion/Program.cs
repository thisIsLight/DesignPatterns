using DependencyInversion.NewFlow;
using DependencyInversion.OldFlow;

namespace DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //One of the best things
            //We need to make sure that if there is a low level call, the source code flow and the execution flow should be in opposite direction

            //With issues
            var caller = new HigherLevelCaller();
            caller.Call();

            //With dependency inversion
            var lowLevelServiceProvider = new NewLowLevelService();
            var newCaller = new NewHighLevelCaller(lowLevelServiceProvider);
            newCaller.Call();
        }
    }
}