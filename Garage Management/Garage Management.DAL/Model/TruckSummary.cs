using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.DAL.Model
{
    public class TruckSummary:Entity
    {
        public Guid Id { get; set; }

        public Guid GarageId { get; set; }

        public Guid TruckId { get; set; }

        public Guid EmployeeId { get; set; }

        public string StartLocation { get; set; }

        public Guid HaltLocation { get; set; }
    }
}
