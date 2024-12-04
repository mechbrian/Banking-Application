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
            AccountNumber = accountNumber;
            Amount = amount;
            Originator = person;
            Time = time;
        }

        public override string ToString()
        {
            return $"Account: {AccountNumber}, Amount: {Amount:C}, Originator: {Originator}, Time: {Time}";
        }
    }
}
