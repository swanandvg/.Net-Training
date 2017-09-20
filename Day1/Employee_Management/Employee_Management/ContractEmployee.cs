using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management
{
    public sealed class ContractEmployee : Employee
    {
        static int ContractEmpNumber = 100;
        #region Constructor
        ContractEmployee(string firstName, string lastName, string empNo, string empCity, EmployeeDesignation empDesig, 
            int empAvailableLeaves, double empSalary)
            :base(firstName,lastName,empCity,empDesig, empAvailableLeaves,empSalary, EmployeeType.Permanent)
        {
            this.EmpNo = "CR" + (++ContractEmpNumber);

        }
        #endregion
    }
}
