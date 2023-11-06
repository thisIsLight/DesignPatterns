using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponisibility
{
    public class ProcessName : BankAcountProcess
    {
        public string Name;
        public ProcessName(BankAccount account, string name) : base(account)
        {
            Name = name;
        }

        public override void RunProcess()
        {
            Console.WriteLine("Changing Name");
            Account.Name = Name;
            base.RunProcess();
        }
    }
}
