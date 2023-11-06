using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class BankAccount
    {
        private int Balance;

        public BankAccount(int balance)
        {
            Balance = balance;
        }

        public int GetBalance()
        {
            return Balance;
        }

        public BankMemento Deposit(int amount)
        {
            Balance += amount;
            return new BankMemento(Balance);
        }

        public void Recover(BankMemento memento)
        {
            Balance = memento.GetBalance();
        }
    }
}
