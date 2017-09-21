using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var empList = new List<Employee>()
            {
                new Employee() {EmpNo=101, EmpName="Iron Man", EmpCity="Mumbai", EmpDesignation="HR", EmpSalary=8000 },
                new Employee() {EmpNo=102, EmpName="Captain America", EmpCity="Bengaluru", EmpDesignation="Devloper", EmpSalary=9000 },
                new Employee() {EmpNo=103, EmpName="Hawk Eye", EmpCity="Mumbai", EmpDesignation="Manager", EmpSalary=10000 },
                new Employee() {EmpNo=104, EmpName="Black Widow", EmpCity="Chennai", EmpDesignation="Manager", EmpSalary=7000 },
                new Employee() {EmpNo=105, EmpName="Hulk", EmpCity="Mumbai", EmpDesignation="HR", EmpSalary=10000 },
                new Employee() {EmpNo=106, EmpName="Scarlett Witch", EmpCity="Bengaluru", EmpDesignation="Devloper", EmpSalary=9000 },
                new Employee() {EmpNo=107, EmpName="The Vision", EmpCity="Mumbai", EmpDesignation="HR", EmpSalary=8000 },
                new Employee() {EmpNo=108, EmpName="Ant Man", EmpCity="Mumbai", EmpDesignation="Manager", EmpSalary=8000 },
                new Employee() {EmpNo=109, EmpName="Spider Man", EmpCity="Bengaluru", EmpDesignation="Devloper", EmpSalary=7000 },
                new Employee() {EmpNo=110, EmpName="War Machine", EmpCity="Chennai", EmpDesignation="Devloper", EmpSalary=8000 },
                new Employee() {EmpNo=111, EmpName="Winter Soldier", EmpCity="Chennai", EmpDesignation="HR", EmpSalary=5000 },
                new Employee() {EmpNo=118, EmpName="Red Skull", EmpCity="Bengaluru", EmpDesignation="HR", EmpSalary=8000 },
                new Employee() {EmpNo=112, EmpName="Superman", EmpCity="Bengaluru", EmpDesignation="Devloper", EmpSalary=9000 },
                new Employee() {EmpNo=113, EmpName="Batman", EmpCity="Bengaluru", EmpDesignation="HR", EmpSalary=10000 },
                new Employee() {EmpNo=114, EmpName="Aqua Man", EmpCity="Mumbai", EmpDesignation="Devloper", EmpSalary=9000 },
                new Employee() {EmpNo=115, EmpName="Flash", EmpCity="Chennai", EmpDesignation="Devloper", EmpSalary=8000 },
                new Employee() {EmpNo=116, EmpName="Arrow", EmpCity="Bengaluru", EmpDesignation="Manager", EmpSalary=9000 },
                new Employee() {EmpNo=117, EmpName="Wonder Woman", EmpCity="Mumbai", EmpDesignation="Devloper", EmpSalary=9000 },
                new Employee() {EmpNo=119, EmpName="Falcon", EmpCity="Mumbai", EmpDesignation="Devloper", EmpSalary=9000 },
                new Employee() {EmpNo=120, EmpName="Red Hulk", EmpCity="Mumbai", EmpDesignation="Devloper", EmpSalary=9000 }
            };
            #region select *
            //var allEmployees = from a in empList
            //                   select a;

            //PrintList(allEmployees)
            #endregion

            #region All Employees in Mumbai
            //var empMumbai = from a in empList
            //                where a.EmpCity == "Mumbai"
            //                select a;
            //PrintList(empMumbai);
            #endregion

            #region Mumbai Dev
            //var empMumbaiDev = from a in empList
            //                   where a.EmpCity == "Mumbai" && a.EmpDesignation == "Devloper"
            //                   select a;
            //PrintList(empMumbaiDev);
            #endregion

            #region sorted Mumbai emp (order by name)
            //var sortedEmpMumbai = from a in empList
            //                      where a.EmpCity == "Mumbai"
            //                      orderby a.EmpName
            //                      select a;
            //PrintList(sortedEmpMumbai);
            #endregion

            #region salary >8000 and sorted by designation descending
            //var sortedEmp = from a in empList
            //                where a.EmpSalary > 8000
            //                orderby a.EmpDesignation descending
            //                select a;
            //PrintList(sortedEmp);
            #endregion

            #region limited columns (only name and designations)
            //var nameAndDesignation = from a in empList
            //                         select new { a.EmpName, a.EmpDesignation };
            //foreach (var item in nameAndDesignation)
            //{
            //    Console.WriteLine(item.EmpName+"\t"+item.EmpDesignation);
            //}
            #endregion

            #region select with calculations
            //var salaryDetails = from a in empList
            //                    select new
            //                    {
            //                        Salary = a.EmpSalary,
            //                        Bonus = a.EmpSalary * 0.2,
            //                        PF = a.EmpSalary * 0.1,
            //                        HRA = a.EmpSalary*0.25
            //                    };
            //foreach (var item in salaryDetails)
            //{
            //    Console.WriteLine(item.Salary+"\t"+item.Bonus+"\t"+item.PF+"\t"+item.HRA);
            //}
            #endregion

            #region select with aggregate functions
            var totalSalary = (from a in empList
                               select a.EmpSalary).Sum();
            var minSalary = (from a in empList
                             select a.EmpSalary).Min();
            var maxSalary = (from a in empList
                             select a.EmpSalary).Max();
            var avgSalary = (from a in empList
                             select a.EmpSalary).Average();
            var countEmp = (from a in empList
                             select a.EmpNo).Count();

            //people startswith H
            var empSearchByName = from a in empList
                                  where a.EmpName.StartsWith("H")
                                  select a;
            PrintList(empSearchByName);
            Console.WriteLine();
            Console.WriteLine();

            //people name endswith "an"
            var empEndsWith = from a in empList
                              where a.EmpName.EndsWith("an")
                              select a;
            PrintList(empEndsWith);
            Console.WriteLine();
            Console.WriteLine();

            //people contains "ro"
            var substringInEmpName = from a in empList
                                     where a.EmpName.Contains("ro")
                                     select a;
            PrintList(substringInEmpName);
            Console.WriteLine();
            Console.WriteLine();

            //people name substring from index 2
            var empNameFromIndex2 = from a in empList
                                     where a.EmpName.Substring(2)
                                     select a;
            #endregion

        }

        static void PrintList(IEnumerable<Employee> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.EmpNo+"\t"+item.EmpName+"\t"+item.EmpDesignation + "\t" + item.EmpCity + "\t" + item.EmpSalary);
            }
        }
    }
}
