using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsGui
{
    internal class SavingAccount : Account
    {
        public SavingAccount(string type, double balance) : base(type, balance)
        {
        }

        public override void PrepareMonthlyStatement()
        {
            throw new NotImplementedException();
        }
    }
}

