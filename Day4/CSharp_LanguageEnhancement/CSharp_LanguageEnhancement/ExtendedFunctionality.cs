using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp_LanguageEnhancement
{
    public static class ExtendedFunctionality
    {
        public static int Transfer(this Accounts ac,int fromAccNo, int toAccNo)
        {
            
            return 10;
        }

        public static void PrintInfo(this Accounts ac, int accNo)
        {
            Console.WriteLine("Name :"+ac.AccName);
            Console.WriteLine("Account No: "+ac.AccNumber);
            Console.WriteLine("Account Balance: "+ac.AccBalance);
            Console.WriteLine("Account Type: "+ac.AccType);
        }

        public static void PrintGreetings(this string str)
        {
            Console.WriteLine("Hello "+str);
        }
    }
}
