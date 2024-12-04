using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsGui
{
    public class CheckingAccount : Account, ITransaction
    {
        private const decimal COST_PER_TRANSACTION = 0.05m;
        private const decimal INTEREST_RATE = 0.005m;
        private readonly bool hasOverdraft;

        public CheckingAccount(decimal balance = 0, bool hasOverdraft = false) : base("CK-", balance)
        {
            this.hasOverdraft = hasOverdraft;
        }

        public new void Deposit(decimal amount, Person person)
        {
            try
            {
                //base.Deposit(amount, person);
                //base.OnTransactionOccur(this, new );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Withdraw(decimal amount, Person person)
        {
            try
            {
                if (this.IsUser(person.Name) == false)
                {
                    //this.OnTransactionOccur();
                    //throw new AccountException();
                }

                if (person.IsAuthenticated == false)
                {
                    //this.OnTransactionOccur();
                    //throw new AccountException();
                }

                if (amount > this.Balance && this.hasOverdraft == false)
                {
                    //this.OnTransactionOccur();
                    //throw new AccountException();
                }

                base.Deposit(-amount, person);
                //this.OnTransactionOccur(this,)

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
