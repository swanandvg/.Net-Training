using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Library
{
    public sealed class PF : Accounts
    {
        static int _autoPFAccountNum = 2000;
        double MaximumWidrawAmount;

        public override double Withdraw(int p_widrawalAmount)
        {
            //return base.Withdraw(p_widrawalAmount);
            MaximumWidrawAmount = AccountBalance * 0.6;
            if (p_widrawalAmount > MaximumWidrawAmount)
            {
                throw new Exception("Maximum Widrawl Amount is " + MaximumWidrawAmount);
            }
            return base.Withdraw(p_widrawalAmount);
        }

        public PF(string name, double initialBalance, AccountType_Nature accType):base(name,initialBalance,accType)
        {
            //this.AccountName = name;
            ////this.AccountNumber = accountNum;
            //this.AccountBalance = initialBalance;
            //this.AccountType = accType;
            this.AccountNumber = "PF" + (++_autoPFAccountNum);
        }
    }
}
