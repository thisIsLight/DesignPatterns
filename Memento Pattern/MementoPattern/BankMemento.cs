using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class BankMemento
    {
        private int Balance;
        public BankMemento(int balance)
        {
            Balance = balance;
        }

        public int GetBalance()
        {
            return Balance;
        }
    }
}
