using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsGui
{
    public class SavingAccount : Account, ITransaction
    {
        private static decimal COST_PER_TRANSACTION = 0.5m;
        private static decimal INTEREST_RATE = 0.015m;

        public SavingAccount(decimal balance = 0) : base("SV-", balance) { }

        public new void Deposit(decimal amount, Person person)
        {
            if (!IsUser(person.Name))
            {
                OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, false));
                throw new AccountException(ExceptionType.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);
            }

            if (!person.IsAuthenticated)
            {
                OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, false));
                throw new AccountException(ExceptionType.USER_NOT_LOGGED_IN);
            }

            base.Deposit(amount, person);
            OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, true));
        }

        public void Withdraw(decimal amount, Person person)
        {
            if (!IsUser(person.Name))
            {
                OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, false));
                throw new AccountException(ExceptionType.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);
            }

            if (!person.IsAuthenticated)
            {
                OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, false));
                throw new AccountException(ExceptionType.USER_NOT_LOGGED_IN);
            }

            if (amount > Balance)
            {
                OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, false));
                throw new AccountException(ExceptionType.NO_OVERDRAFT_FOR_THIS_ACCOUNT);
            }

            base.Deposit(-amount, person);
            OnTransactionOccur(this, new TransactionEventArgs(person.Name, -amount, true));
        }

        public override void PrepareMonthlyStatement()
        {
            try
            {
                decimal serviceCharge = this.transactions.Count * COST_PER_TRANSACTION;
                decimal interest = (LowestBalance * INTEREST_RATE) / 12;

                this.Balance += interest - serviceCharge;

                transactions.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
