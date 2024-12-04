using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsGui
{
    public struct Transaction
    {
        public string AccountNumber { get; }

        public decimal Amount { get; }

        public Person Originator { get; }

        public DateTime Time { get; }

        public Transaction(string accountNumber, decimal amount, Person person, DateTime time)
        {
            this.AccountNumber = accountNumber;
            this.Amount = amount;
            this.Originator = person;
            this.Time = time;
        }

        public Transaction(string accountNumber, decimal amount, Person person, long minutes)
        {
            this.AccountNumber = accountNumber;
            this.Amount = amount;
            this.Originator = person;
            this.Time = Utils.BaseTime.AddMinutes(minutes);
        }

        public override string ToString()
        {
            return $"Account: {AccountNumber}, Amount: {Amount:C}, Originator: {Originator}, Time: {Time}";
        }
    }
}
