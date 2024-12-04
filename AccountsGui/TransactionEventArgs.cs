using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsGui
{
    internal class TransactionEventArgs : LoginEventArgs
    {
        public decimal Amount { get; }
<<<<<<< HEAD
=======

>>>>>>> origin/master
        public TransactionEventArgs(string personName, decimal amount, bool success) : base(personName, success)
        {
            this.Amount = amount;
        }
<<<<<<< HEAD


=======
>>>>>>> origin/master
    }
}
