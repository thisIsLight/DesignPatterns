using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponisibility
{
    public class BankAcountProcess
    {
        public BankAccount Account { get; set; }
        public BankAcountProcess Next;

        public BankAcountProcess(BankAccount account)
        {
            Account = account;
        }

        public void AddProcess(BankAcountProcess process)
        {
            if(Next != null)
            {
                Next.Next = process;
            }
            else
            {
                Next = process;
            }
        }

        public virtual void RunProcess() => Next?.RunProcess();
    }
}
