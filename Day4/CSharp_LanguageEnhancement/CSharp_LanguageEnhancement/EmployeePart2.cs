using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_LanguageEnhancement
{
    public partial class Employee
    {
        public string ApplyLeave(int days)
        {
            return "Leave Approved";
        }

        partial void LeaveNotGranted()
        {
            Console.WriteLine("Leave not granted");
        }
    }
}
