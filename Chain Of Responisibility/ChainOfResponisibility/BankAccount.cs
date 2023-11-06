using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponisibility
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public int Balance { get; set; }

        public BankAccount(string name, string sex, string address, string zipCode)
        {
            Name = name;
            Sex = sex;
            Address = address; ZipCode = zipCode;
            ZipCode = zipCode;
            Balance = 0;
        }

        public void Deposite(int amount)
        {
            Balance += amount;
        }
        public void Withdraw(int amount)
        {
            Balance -= amount;
        }
    }
}
