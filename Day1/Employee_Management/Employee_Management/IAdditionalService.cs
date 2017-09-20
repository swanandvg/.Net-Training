using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management
{
    public interface IAdditionalService
    {
        bool ApplyLeave(int Days);
        bool ApplyPromotion();
        bool ChangeTeam();
    }
}
