using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class BankAccount
    {
        public string Number;
        public string DepositType;
        public decimal balance;
        public DateTime OpenTime;
        public Owner owner;
        public bool smsNotific;
        public bool internetBank;
        public List<Transaction> transactions = new List<Transaction>();
    }

    internal class Owner
    {
        static int OwnerId = 0;
        public string Name { get; set; }
        public DateTime birthDay;
        public string passport;

        public Owner()
        {
            OwnerId++;
        }
    }

    internal class Transaction
    {
        public string type;
        public decimal Amount;
        public DateTime Date;
    }
}
