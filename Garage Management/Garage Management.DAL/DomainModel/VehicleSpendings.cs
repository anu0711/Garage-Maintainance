using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.DAL.DomainModel
{
    public class VehicleSpendings
    {
        public string VehicleName { get; set; }
        public string vehicleType { get; set; }
        public string VehicleNumber { get; set; }
        public string Detail { get; set; }
        public long Amount { get; set; }
    }
}
