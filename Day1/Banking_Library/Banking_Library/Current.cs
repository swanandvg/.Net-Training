using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Library
{
    public sealed class Current : Accounts
    {
        static int _autoCurrentAccountNum = 500;
        int MaximumWidrawAmount = 50000;
        public override double Withdraw(int p_widrawalAmount)
        {
            //return base.Withdraw(p_widrawalAmount);
            if (p_widrawalAmount > MaximumWidrawAmount)
            {
                throw new Exception("Maximum Widrawl Amount is " + MaximumWidrawAmount);
            }
            return base.Withdraw(p_widrawalAmount);
        }

        public Current(string name,  double initialBalance, AccountType_Nature accType):base(name,initialBalance,accType)
        {
            //this.AccountName = name;
            ////this.AccountNumber = accountNum;
            //this.AccountBalance = initialBalance;
            //this.AccountType = accType;
            this.AccountNumber = "CUR" + (++_autoCurrentAccountNum);
        }
    }
}
