using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.DAL.Model
{
    public class TruckSummary:Entity
    {
        public long Id { get; set; }

        public long GarageId { get; set; }

        public long TruckId { get; set; }

        public long EmployeeId { get; set; }

        public string StartLocation { get; set; }

        public long HaltLocation { get; set; }
    }
}
