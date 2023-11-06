using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Command
{
    public class AccountCommand : ICommand
    {
        public BankAccount Account { get; set; }
        
        public enum BankActions
        {
            Deposit,Withdraw
        }
        public BankActions Actions { get; set; }
        public int Amount;

        public AccountCommand(BankAccount account,BankActions action, int amount)
        {
            Account = account;
            Actions = action;
            Amount = amount;
        }

        public void Call()
        {
            switch (Actions)
            {
                case BankActions.Deposit:
                    Account.Deposit(Amount);
                    break;
                case BankActions.Withdraw: 
                    Account.Withdraw(Amount);
                    break;
                default: break;
            }
        }

        public void Undo()
        {
            switch (Actions)
            {
                case BankActions.Deposit:
                    Account.Withdraw(Amount);
                    break;
                case BankActions.Withdraw:
                    Account.Deposit(Amount);
                    break;
                default: break;
            }
        }
    }
}
