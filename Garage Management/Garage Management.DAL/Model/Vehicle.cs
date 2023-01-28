using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.DAL.Model
{
    public class Vehicle : Entity
    {
        public long Id { get; set; }
        public string VehicleName { get; set; }
        public string vehicleType { get; set; }
        public bool RcStatus { get; set; }
        public DateTime InsuranceValidation { get; set; }
        public DateTime Validity { get; set; }
    }
}
