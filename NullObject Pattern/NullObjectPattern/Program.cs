using NullObjectPattern.Bank;
using NullObjectPattern.Log;

namespace NullObjectPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating logger
            var consoleLogger = new ConsoleLog();
            var account1 = new Account(100);

            var account2 = new Account(100, consoleLogger);

            account1.Deposit(100);
            account2.Deposit(100);
        }
    }
}