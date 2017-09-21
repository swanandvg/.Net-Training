using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_LanguageEnhancement
{
    public class Accounts
    {
        #region properties
        public int AccNumber { get; set; }
        public string AccName { get; set; }
        public double AccBalance { get; set; }
        public bool isPermanent { get; set; }
        public string AccType { get; set; }
        #endregion

        #region methods
        public int Widraw(int amount)
        {
            AccBalance -= amount;
            return 10;
        }

        public double Deposit(int amount)
        {
            AccBalance += amount;
            return AccBalance;
        }
        #endregion
    }
}
