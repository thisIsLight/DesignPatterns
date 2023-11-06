using NullObjectPattern.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern.Bank
{
    public class Account
    {
        private ILog log = NullLog.GetInstance();
        public int Balance;

        public Account(int amount, ILog? logger = null)
        {
            Balance = amount;
            if(logger != null) { log = logger; }
            
        }

        public void Deposit(int amount)
        {
            Balance = amount;
            log.Info();
        }
    }
}
