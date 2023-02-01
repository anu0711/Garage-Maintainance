using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.DAL.DomainModel
{
    public class MaintenanceSummaryDomain
    {
        public string Detail { get; set; }
        public long Amount { get; set; }
        public bool IsOwner { get; set; }
        public Guid TruckId { get; set; }
        public string VehicleName { get; set; }
        public string vehicleType { get; set; }
        public string vehicleNumber { get; set; }
        public bool RcStatus { get; set; }
        public DateTime InsuranceValidation { get; set; }
        public DateTime FitnessValidity { get; set; }
    }
}
