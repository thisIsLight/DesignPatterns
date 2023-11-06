namespace ChainOfResponisibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We want to have a bank account in which the changes are done in an order.
            //Change Name
            //Change Sex
            var account = new BankAccount("Sahil", "M", "Lucknow", "226006");

            var bankAcountProcess = new BankAcountProcess(account);

            var nameProcess = new ProcessName(account, "Keerthana");
            bankAcountProcess.AddProcess(nameProcess);

            var sexProcess = new ProcessSex(account, "F");
            bankAcountProcess.AddProcess(sexProcess);

            bankAcountProcess.RunProcess();

            Console.WriteLine(account.Name);
            Console.WriteLine(account.Sex);
        }
    }
}