using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsGui
{
    public class VisaAccount : Account
    {
        private decimal creditLimit;
        private const decimal INTEREST_RATE = 0.1995m;

        public VisaAccount(decimal balance = 0, decimal creditLimit = 1200)
            : base("VS-", balance)
        {
            this.creditLimit = creditLimit;
        }

        public void DoPayment(decimal amount, Person person)
        {
            try
            {
                //if (!IsUser(person.Name))
                //    throw new AccountException(ExceptionType.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);

                //if (!person.IsAuthenticated)
                //    throw new AccountException(ExceptionType.USER_NOT_LOGGED_IN);

                Deposit(amount, person);
                OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, true));
            }
            catch (AccountException accex)
            {
                Console.WriteLine($"{person} is not in this account.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
                return;
            }

        }

        public void DoPurchase(decimal amount, Person person)
        {
            try
            {
                if (!IsUser(person.Name))
                    throw new AccountException(ExceptionType.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);

                if (!person.IsAuthenticated)
                    throw new AccountException(ExceptionType.USER_NOT_LOGGED_IN);

                if (Balance - amount < -creditLimit)
                    throw new AccountException(ExceptionType.CREDIT_LIMIT_HAS_BEEN_EXCEEDED);

                Deposit(-amount, person);
                OnTransactionOccur(this, new TransactionEventArgs(person.Name, -amount, true));
            }
            catch (AccountException accex)
            {
                Console.WriteLine(accex.Message);
            }
            catch (Exception ex)
            {
                //throw;
                Console.WriteLine(ex.Message);
                return;
            }
        }

        public override void PrepareMonthlyStatement()
        {
            decimal interest = (LowestBalance * INTEREST_RATE) / 12;
            Balance -= interest;
            transactions.Clear();
        }
    }
}
