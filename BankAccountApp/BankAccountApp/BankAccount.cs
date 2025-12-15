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
        public decimal AccountBalance { get; set; }

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
    }
}
