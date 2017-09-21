using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_LanguageEnhancement
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variant
            //var name = "Swanand";
            //var age = 30;
            //var salary = 50000.00;
            //var isPermanent = true;

            //Console.WriteLine(name.GetType());
            //Console.WriteLine(age.GetType());
            //Console.WriteLine(salary.GetType());
            //Console.WriteLine(isPermanent.GetType());
            ////Console.WriteLine(name.GetType());

            //var accObj = new Accounts();
            //accObj.AccNumber = 101;
            //accObj.AccBalance = 5000;

            //var bal = accObj.Widraw(600);
            //var bal2 = accObj.Deposit(2000);

            //Console.WriteLine(accObj.GetType());
            //Console.WriteLine(bal.GetType());
            //Console.WriteLine(bal2.GetType());
            #endregion

            #region Automatic Objects and Object Inilializer
            //var accObj1 = new Accounts();
            //accObj1.AccNumber = 101;
            //accObj1.AccBalance = 5000;
            //accObj1.AccName = "Swnanand";
            //accObj1.AccType = "Savings";
            //accObj1.isPermanent = true;

            //var accObj2 = new Accounts() { AccName="Nand", AccNumber=102, AccBalance=10000, AccType="Current", isPermanent=false};

            ////Automatic Objects
            //var objEmp1 = new { empNo = "170046", empName = "Swnanad G", empDesig = "Software Quality Engineer" };
            //var objEmp2 = new { empNo = "170046", empName = "Swnanad G", empDesig = "Software Quality Engineer" };
            //Console.WriteLine(objEmp1.GetType());
            //Console.WriteLine(objEmp2.GetType());

            //var listAccounts1 = new List<Accounts>();
            //listAccounts1.Add(new Accounts() { AccName = "Swanand", AccNumber = 101, AccBalance = 10000, AccType = "Current", isPermanent = false });
            //listAccounts1.Add(new Accounts() { AccName = "Nand", AccNumber = 102, AccBalance = 20000, AccType = "Savings", isPermanent = true });
            //listAccounts1.Add(new Accounts() { AccName = "Swan", AccNumber = 103, AccBalance = 30000, AccType = "Current", isPermanent = true });
            //listAccounts1.Add(new Accounts() { AccName = "Swany", AccNumber = 104, AccBalance = 40000, AccType = "PF", isPermanent = true });
            //listAccounts1.Add(new Accounts() { AccName = "Andya", AccNumber = 105, AccBalance = 50000, AccType = "Current", isPermanent = false });

            ////Object Initializer
            //var listAccounts2 = new List<Accounts>() { new Accounts() { AccName = "Swanand", AccNumber = 101, AccBalance = 10000, AccType = "Current", isPermanent = false },
            //                                           new Accounts() { AccName = "Nand", AccNumber = 102, AccBalance = 20000, AccType = "Savings", isPermanent = true },
            //                                           new Accounts() { AccName = "Swan", AccNumber = 103, AccBalance = 30000, AccType = "Current", isPermanent = true },
            //                                           new Accounts() { AccName = "Swany", AccNumber = 104, AccBalance = 40000, AccType = "PF", isPermanent = true },
            //                                           new Accounts() { AccName = "Andya", AccNumber = 105, AccBalance = 50000, AccType = "Current", isPermanent = false }
            //                                         };
            #endregion

            #region Extension Method
            //Transfer Method is written in ExtendedFunctionality.cs
            //Accounts acc = new Accounts();
            //var result = acc.Transfer(10, 20);

            //Accounts acc1 = new Accounts() { AccName = "Nand", AccNumber = 102, AccBalance = 10000, AccType = "Current", isPermanent = false };
            //acc1.PrintInfo(acc1.AccNumber);

            //Console.WriteLine("Enter your name: ");
            //var str = Console.ReadLine();
            //str.PrintGreetings();
            #endregion

            #region partial classes
            //Employee is partial class written in Employee.cs and EmployeePart2.cs
            var emp = new Employee();
            Console.WriteLine(emp.ApplyLeave(20));
            Console.WriteLine(emp.GetBonus(20));
            
            

            #endregion
        }
    }
}
