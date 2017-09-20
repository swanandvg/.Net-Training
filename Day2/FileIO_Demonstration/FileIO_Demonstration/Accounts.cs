using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_Demonstration
{
    [Serializable]
    public class Accounts
    {
        #region properties
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public double AccountBalance { get; set; }
        public string AccountType { get; set; }
        #endregion

        #region Swanand's Methods
        public void Widraw1(double amount)  //written by me
        {
            if(amount>0 && amount <= AccountBalance)
            AccountBalance -= amount;
           
        }
        public void Deposit1(double amount) //written by me
        {
            AccountBalance += amount;
           
        }
        #endregion

        #region Nikhil's Method
        public double Widraw(int widrawalAmount, int accountNo) //written by Nikhil
        {
            if (File.Exists("soap\\" + accountNo + ".xml"))
            {
                FileStream readFile = new FileStream("soap\\" + accountNo + ".xml", FileMode.Open, FileAccess.Read);
                SoapFormatter format = new SoapFormatter();
                Accounts acc = (Accounts)format.Deserialize(readFile);
                acc.AccountBalance = acc.AccountBalance - widrawalAmount;
                readFile.Close();

                FileStream writeFile = new FileStream("soap\\" + accountNo + ".xml", FileMode.Create, FileAccess.Write);
                format.Serialize(writeFile, acc);
                writeFile.Close();
                return AccountBalance;
            }
            throw new Exception("Invalid account Number");
        }

        public double Deposit(int depositAmount, int accountNo) //written by Nikhil
        {
            if (File.Exists("soap\\" + accountNo + ".xml"))
            {
                FileStream readFile = new FileStream("soap\\" + accountNo + ".xml", FileMode.Open, FileAccess.Read);
                SoapFormatter format = new SoapFormatter();
                Accounts acc = (Accounts)format.Deserialize(readFile);
                acc.AccountBalance = acc.AccountBalance + depositAmount;
                readFile.Close();

                FileStream writeFile = new FileStream("soap\\" + accountNo + ".xml", FileMode.Create, FileAccess.Write);
                format.Serialize(writeFile, acc);
                writeFile.Close();
                return AccountBalance;
            }
            throw new Exception("Invalid account Number");
        }
        #endregion

        #region Constructor
        public Accounts()
        {
            int accNo;
            #region Swanand's Way
            #region Read Account Number from File
            try
            {
                FileStream readFile = new FileStream("accNo.txt", FileMode.Open, FileAccess.Read);
                StreamReader rd = new StreamReader(readFile);

                accNo = Convert.ToInt32(rd.ReadLine());
                rd.Close();
                readFile.Close();
            }
            catch (FileNotFoundException)
            {
                accNo = 100;
            }
            catch (Exception)
            {
                accNo = 100;
            }
            #endregion


            accNo++;
            AccountNumber = accNo;

            #region Write new Account Number to File
            FileStream writeFile = new FileStream("accNo.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter wr = new StreamWriter(writeFile);

            wr.WriteLine(accNo);
            wr.Close();
            writeFile.Close();

            #endregion
            #endregion

            //#region Nikhil
            //if (File.Exists("accNo.txt"))
            //{


            //    FileStream readFile1 = new FileStream("accNo.txt", FileMode.Open, FileAccess.Read);
            //    StreamReader rd1 = new StreamReader(readFile1);

            //    accNo = Convert.ToInt32(rd1.ReadLine());
            //    rd1.Close();
            //    readFile1.Close();

            //    #endregion

            //    accNo++;
            //    AccountNumber = accNo;

            //    #region Write new Account Number to File
            //    FileStream writeFile1 = new FileStream("accNo.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //    StreamWriter wr1 = new StreamWriter(writeFile1);

            //    wr1.WriteLine(accNo);
            //    wr1.Close();
            //    writeFile1.Close();
            //    #endregion
            //}
            //else
            //{
            //    FileStream
            //}
        }
        #endregion 

    }
}
