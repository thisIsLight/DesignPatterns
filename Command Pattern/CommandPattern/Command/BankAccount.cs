namespace CommandPattern.Command
{
    public class BankAccount
    {
        public string Name { get; set; }
        public int Balance;

        public BankAccount(string name)
        {
            Name = name;
            Balance = 0;
        }

        public void Withdraw(int amount)
        {
            Balance -= amount;
        }
        public void Deposit(int amount)
        {
            Balance += amount;
        }
    }
}