using System;
using lab2;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static bank.Form2;

namespace lab2
{
    public class BankAccount
    {
        [RegularExpression(@"^\d{4}-\d{4}-\d{4}$", ErrorMessage = "Номер счета должен быть в формате 1111-1111-1111")]
        public string Number { get; set; }

        public string DepositType { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Баланс не может быть отрицательным")]
        public decimal balance { get; set; }

        public DateTime OpenTime { get; set; }
        public Owner owner { get; set; }
        public bool smsNotific { get; set; }
        public bool internetBank { get; set; }
        public List<Transaction> transactions { get; set; } = new List<Transaction>();
    }

    public class Owner
    {
        static int OwnerId = 0;
        public string Name { get; set; }
        public DateTime birthDay { get; set; }

        [PassportValidation]
        public string passport { get; set; }

        public Owner()
        {
            OwnerId++;
        }
    }

    public class Transaction
    {
        public string type { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
