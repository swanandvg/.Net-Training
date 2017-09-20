using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking_Library;

namespace Banking_Solution_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Accounts Code
            //Accounts accObj = new Accounts();

            //accObj.AccountNumber = 101;
            //accObj.AccountName = "Vijay Dinanath Chauhan";
            //accObj.AccountBalance = 35000;
            //accObj.AccountType = "saving";

            //Console.WriteLine("Current Balance is "+accObj.AccountBalance);
            //Console.WriteLine("Choose to do a transaction");
            //Console.WriteLine("1. Widraw");
            //Console.WriteLine("2. Deposit");
            //Console.WriteLine("3. Exit");
            //Console.WriteLine("Type your Choice:");

            //int userChoice = Convert.ToInt32(Console.ReadLine());
            //switch (userChoice)
            //{
            //    case 1:
            //        Console.WriteLine("Enter amount for Withdraw");
            //        int withdrawAmount = Convert.ToInt32(Console.ReadLine());
            //        //accObj.Withdraw(withdrawAmount);
            //        Console.WriteLine("Account balnce after withdraw : "+accObj.Withdraw(withdrawAmount));
            //        break;
            //    case 2:
            //        Console.WriteLine("Enter amount for Deposit");
            //        int depositAmount = Convert.ToInt32(Console.ReadLine());
            //        //accObj.Deposit(depositAmount);
            //        Console.WriteLine("Account balance after deposit : "+accObj.Deposit(depositAmount));
            //        break;
            //    case 3:
            //        Console.WriteLine("Program is exiting");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Option");
            //        break;
            //}
            #endregion

            #region Account Declaration
            Accounts savObj1 = new Savings("Vijay Dinanath Chauhan", 4000, Accounts.AccountType_Nature.Child);
            Accounts curObj1 = new Current("Vijay Dinanath Chauhan", 4000, Accounts.AccountType_Nature.Govt);
            Accounts pfObj1 = new PF("Vijay Dinanath Chauhan", 4000, Accounts.AccountType_Nature.Child);
            Accounts savObj2 = new Savings("Vijay Dinanath Chauhan", 4000, Accounts.AccountType_Nature.NRI);
            Accounts curObj2 = new Current("Vijay Dinanath Chauhan", 4000, Accounts.AccountType_Nature.Govt);
            Accounts pfObj2 = new PF("Vijay Dinanath Chauhan", 4000, Accounts.AccountType_Nature.Joint);
            Accounts savObj3 = new Savings("Vijay Dinanath Chauhan", 4000, Accounts.AccountType_Nature.Corporate);
            Accounts curObj3 = new Current("Vijay Dinanath Chauhan", 4000, Accounts.AccountType_Nature.Corporate);
            Accounts pfObj3 = new PF("Vijay Dinanath Chauhan", 4000, Accounts.AccountType_Nature.NRI);
            #endregion

            //savObj.AccountBalance = 25000;
            //Console.WriteLine(savObj.Withdraw(3000));
            //Console.WriteLine(savObj.Withdraw(13000));
            Console.WriteLine("Enter amount for Withdraw");
            int withdrawAmount = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Account balnce after withdraw : " + savObj1.Withdraw(withdrawAmount));
            try
            {
                savObj1.Withdraw(withdrawAmount);
                //curObj1.Withdraw(withdrawAmount);
            }
            catch (NullReferenceException ns)
            {
            }
            catch (ArgumentException ag)
            {
            }
            catch (DivideByZeroException dv)
            {
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //send email or thank you
                //release object
                //release sql
            }
            Console.WriteLine("Account balnce after withdraw : " + savObj1.AccountBalance);
            //Console.WriteLine("Account balnce after withdraw : " + curObj1.AccountBalance);
            //savObj.Add(10, 20);
            //savObj.Add(10, 20, 30);
            //savObj.Add("Hello", "World");
            //savObj.Add(20.1, 23.5);

            //Console.WriteLine(savObj.Add(10, 20, 30, 40, 50, 60, 70, 80, 90, 100));


        }
    }
}
