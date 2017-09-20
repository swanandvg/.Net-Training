using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management
{
    public abstract class Employee : IService
    {
        #region My Enumeration
        public enum EmployeeDesignation
        {
            Developer,Manager,HR
        }
        public enum EmployeeType
        {
            Permanent,Contract
        }
        #endregion

        #region My Variables
        string _EmpFirstName;
        string _EmpLastName;
        string _EmpNo;
        string _EmpCity;
        int _EmpAvailableLeaves;
        double _EmpSalary;

        string _EmpDesignation;
        string _EmpType;
        #endregion

        #region My Properties
        public string EmpFirstName { get { return _EmpFirstName; } set { _EmpFirstName = value; } }
        public string EmpLastName { get { return _EmpLastName; } set { _EmpLastName = value; } }
        public string EmpNo { get { return _EmpNo; } set { _EmpNo = value; } }
        public string EmpCity { get { return _EmpCity; } set { _EmpCity = value; } }
        public int EmpAvailableLeaves { get { return _EmpAvailableLeaves; } set { _EmpAvailableLeaves = value; } }
        public double EmpSalary { get {return _EmpSalary; } set { _EmpSalary = value; } }
        public string EmpDesignation { get { return _EmpDesignation; } set { _EmpDesignation = value; } }
        public string EmpType { get { return _EmpType; } set { _EmpType = value; } }
        #endregion

        #region Constructor
        public Employee(string firstName, string lastName, string empCity, EmployeeDesignation empDesig, int empAvailableLeaves, double empSalary, EmployeeType empType)
        {
            this.EmpFirstName = firstName;
            this.EmpLastName = lastName;
            //this.EmpNo = empNo;
            this.EmpDesignation = empDesig.ToString();
            this.EmpAvailableLeaves = empAvailableLeaves;
            this.EmpSalary = empSalary;
            this.EmpType = empType.ToString();
        }
        #endregion

        #region IService Methods
        public double CalculateBonus(double Percentage)
        {
            return EmpSalary * 0.15;
        }

        public int CheckLeavesAvailable()
        {
            return EmpAvailableLeaves;
        }
        #endregion
    }
}
