using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.DAL.Model
{
    public class EmployeeSummary:Entity
    {
        public long Id { get; set; }

        public long EmployeeId { get; set; }

        public long LeaveDays { get; set; }

        public long WorkingDays { get; set; }

        public long CreditAmount { get; set; }

        public long DamageCost { get; set; }
    }
}
