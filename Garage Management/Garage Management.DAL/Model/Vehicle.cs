using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.DAL.Model
{
    public class Vehicle : Entity
    {
        public string VehicleName { get; set; }
        public string vehicleType { get; set; }
        public bool RcActive { get; set; }
        public string VehicleNumber { get; set; }
        public DateTime InsuranceValidity { get; set; }
        public DateTime FitnessValidity { get; set; }
    }
}
