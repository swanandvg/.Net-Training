using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Library
{
    public abstract class Accounts
    {
        #region My Enums
        public enum AccountType_Nature
        {
            Child,Joint,NRI,Corporate,Govt
        }
        #endregion

        #region My Variables
        //static int _autoAccountNumber=100;
        //static int _autoCurrentAccountNum = 500;
        //static int _autoPFAccountNum = 2000;
        //static int _autoSavingsAccountNum = 100;

        string _name;
        string _accNumber;
        double _accBalance;
        string _accType;
        #endregion

        #region My Properties
        public string AccountName { get { return _name; } set { _name = value; } }
        public string AccountNumber { get { return _accNumber; } set { _accNumber = value; } }
        public double AccountBalance { get { return _accBalance; } set { _accBalance = value; } }
        public string AccountType { get { return _accType; } set { _accType = value; } }
        #endregion

        #region My Methods
        public virtual double Withdraw(int p_widrawalAmount)
        {
            //trying to connect to db
            //throw new System.Data.SqlClient.SqlException("Server not available")
            if(p_widrawalAmount==null)
            {
                throw new NullReferenceException();
            }
            if (p_widrawalAmount<0)
            {
                throw new Exception("Negative widrawl of money");
            }
            if (AccountNumber.StartsWith("CUR"))
            {
                if (p_widrawalAmount > AccountBalance + 20000)
                {
                    throw new Exception("Insufficient Balance");
                }
            }
            else if (p_widrawalAmount>AccountBalance)
            {
                throw new Exception("Insufficient Balance");
            }
            AccountBalance -= p_widrawalAmount;
            return AccountBalance;
        }

        public virtual double Deposit(int p_depositAmount)
        {
            AccountBalance += p_depositAmount;
            return AccountBalance;
        }

        //public int Add (int num1, int num2)
        //{
        //    return num1 + num2;
        //}
        //public int Add(int num1, int num2, int num3)
        //{
        //    return num1 + num2 + num3;
        //}
        public int Add(int num1, int num2, params int [] num3)
        {
            int temp = 0;
            for (int i = 0; i < num3.Length; i++)
            {
                temp += num3[i];
            }
            return num1 + num2 + temp;
        }

        //public double Add(double num1,double num2)
        //{
        //    return num1 + num2;
        //}
        public double Add(double num1, double num2, params double[] num3)
        {
            double temp = 0;
            for (int i = 0; i < num3.Length; i++)
            {
                temp += num3[i];
            }
            return num1 + num2 + temp;
        }
        public string Add(string name1,string name2)
        {
            return name1 + " " + name2;
        }
        #endregion

        #region My Constructors
        public Accounts(string name, double initialBalance, AccountType_Nature type)
        {
            this.AccountName = name;
            this.AccountBalance = initialBalance;
            this.AccountType = type.ToString();
            //this.AccountNumber = accountNum;
            //check all values above for validation and then allocate account number
            //this.AccountNumber = ++_autoAccountNumber;
            //this.AccountNumber = (String.Equals(accType, "Savings") ? "SAV" + (++_autoSavingsAccountNum) : String.Equals(accType, "PF") ? "PF" + (++_autoPFAccountNum) : "CUR" + (++_autoCurrentAccountNum));
        }

        //public Accounts(string name, string accountNum, double initialBalance, string accType)
        //{
        //    this.AccountName = name;
        //    this.AccountBalance = initialBalance;
        //    this.AccountType = accType;
        //    //this.AccountNumber = accountNum;
        //    //check all values above for validation and then allocate account number
        //    this.AccountNumber = accountNum;
        //}

        //public Accounts() { }
        #endregion
    }
}
