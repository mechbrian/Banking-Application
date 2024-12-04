using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsGui
{
    internal class SavingAccount : Account
    {
        public SavingAccount(decimal balance = 0) : base("SV-",balance)
        {
        }
        public SavingAccount(string type, decimal balance) : base(type, balance)
        {
        }

        public override void PrepareMonthlyStatement()
        {
            throw new NotImplementedException();
        }
    }
}

