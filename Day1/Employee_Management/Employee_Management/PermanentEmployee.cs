using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management
{
    public sealed class PermanentEmployee : Employee, IAdditionalService
    {
        static int PermanentEmpNumber = 500;

        #region Constructor
        PermanentEmployee(string firstName, string lastName, string empNo, string empCity, EmployeeDesignation empDesig, int empAvailableLeaves, double empSalary)
            :base(firstName,lastName,empCity,empDesig, empAvailableLeaves,empSalary, EmployeeType.Permanent)
        {
            this.EmpNo = "PR" + (++PermanentEmpNumber);
            
        }
        #endregion

        #region IAdditionalService
        public bool ApplyLeave(int Days)
        {
            if (Days <= 0)
                throw new Exception("Leave should not be 0 or less than it");
            if (Days > EmpAvailableLeaves)
                throw new Exception("Applied Leaves are greater than available leaves");

            EmpAvailableLeaves -= Days;
            return true;
        }

        public bool ApplyPromotion()
        {
            if (String.Equals(EmpDesignation, EmployeeDesignation.HR.ToString()))
                throw new Exception("HR Can't apply for promotion");
            return true;
        }

        public bool ChangeTeam()
        {
            return true;
        }
        #endregion
    }
}
