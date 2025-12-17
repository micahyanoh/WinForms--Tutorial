using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    public class BankAccount
    {
        public string AccountOwner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal AccountBalance { get; protected set; }

        // constructors

        /*
         -they need to be inside the class they belong to
        -they have the same name as the class
        -they don't have a return type
        -they should be public
         
         */

        public  BankAccount(string owner)
        {
            AccountOwner = owner;
            AccountNumber = Guid.NewGuid();
            AccountBalance = 0;

        }

        public virtual string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return $" You can't Deposit {amount}.";
            }
            if (amount > 10000)
            {
                return $" Deposits over {10000:C} require manager approval.";
            }
            AccountBalance += amount;
            return $"Successfully deposited {amount:C}. New balance is {AccountBalance:C}.";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                return $" You can't Withdraw {amount}.";
            }
            if (amount > AccountBalance)
            {
                return $" Insufficient funds to withdraw {amount:C}. Current balance is {AccountBalance:C}.";
            }
            AccountBalance -= amount;
            return $"Successfully withdrew {amount:C}. New balance is {AccountBalance:C}.";
        }
    }
}
