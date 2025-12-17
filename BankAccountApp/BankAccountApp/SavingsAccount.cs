using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }
        public SavingsAccount(string owner, decimal interestRate) : base(owner + $" ({interestRate} %)")
        {
            InterestRate = interestRate;
        }

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return $" You can't Deposit {amount}.";
            }
            if (amount > 10000)
            {
                return $" Deposits over {10000:C} require manager approval.";
            }
            decimal interest = amount * (InterestRate / 100);
            AccountBalance += amount+interest;
            return $"Successfully deposited {amount:C}. New balance is {AccountBalance:C}.";
        }

    }
}
