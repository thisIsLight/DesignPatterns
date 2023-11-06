namespace MementoPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a bank account
            var account = new BankAccount(100);

            var t1 = account.Deposit(100);
            var t2 = account.Deposit(100);
            var t3 = account.Deposit(100);
            var t4 = account.Deposit(100);
            var t5 = account.Deposit(100);
            var t6 = account.Deposit(100);

            Console.WriteLine(account.GetBalance());

            //We want to revert back to a specific commit
            account.Recover(t4);

            Console.WriteLine(account.GetBalance());
        }
    }
}