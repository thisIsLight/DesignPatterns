using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponisibility
{
    public class ProcessSex : BankAcountProcess
    {
        public string Sex;
        public ProcessSex(BankAccount account, string sex) : base(account)
        {
            Sex = sex;
        }

        public override void RunProcess()
        {
            Console.WriteLine("Changing Name");
            Account.Sex = Sex;
            base.RunProcess();
        }
    }
}
