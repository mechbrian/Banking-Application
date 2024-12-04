using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsGui
{
    public class SavingAccount : Account
    {
        public SavingAccount(decimal balance = 0) : base("SV-",balance)
        {
        }
        public SavingAccount(string type, decimal balance) : base(type, balance)
        {
        }

        public void Deposit(decimal amount, Person person)
        {

        }

        public void Withdraw(decimal amount, Person person)
        {

        }

        public override void PrepareMonthlyStatement()
        {
            throw new NotImplementedException();
        }
    }
}

