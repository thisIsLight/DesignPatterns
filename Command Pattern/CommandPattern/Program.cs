using CommandPattern.Command;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We first create an account
            var account = new BankAccount("Keerthana");

            //We create Deposit and Withdraw commands in a list
            List<AccountCommand> commands = new List<AccountCommand>();

            commands.Add(new AccountCommand(account, AccountCommand.BankActions.Deposit, 100));
            commands.Add(new AccountCommand(account, AccountCommand.BankActions.Deposit, 100));
            commands.Add(new AccountCommand(account, AccountCommand.BankActions.Withdraw, 100));
            commands.Add(new AccountCommand(account, AccountCommand.BankActions.Withdraw, 100));
            commands.Add(new AccountCommand(account, AccountCommand.BankActions.Deposit, 100));

            foreach (var com in commands)
            {
                com.Call();
            }

            Console.WriteLine($"Amount in Account : {account.Balance}");

            commands.Reverse();
            foreach(var com in commands)
            {
                com.Undo();
            }

            Console.WriteLine($"Balance after UNdo : {account.Balance}");
        }
    }
}