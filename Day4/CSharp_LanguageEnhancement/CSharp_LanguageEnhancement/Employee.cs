using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_LanguageEnhancement
{
    public partial class Employee
    {
        public int GetBonus (int Percentage)
        {
            
            Employee emp = new Employee();
            emp.LeaveNotGranted();
            return 200;
        }

        partial void LeaveNotGranted();
        
    }
}
