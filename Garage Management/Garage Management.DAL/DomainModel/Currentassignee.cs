using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.DAL.DomainModel
{
    public class Currentassignee
    {
        public string Location { get; set; }
        public string VehicleName { get; set; }
        public string vehicleType { get; set; }
        public bool RcActive { get; set; }
        public string VehicleNumber { get; set; }
        public DateTime InsuranceValidity { get; set; }
        public DateTime FitnessValidity { get; set; }
        public string EName { get; set; }
        public string LicenseNo { get; set; }
        public int Age { get; set; }
        public string MobileNumber { get; set; }
        public string IdNumber { get; set; }
        public string Address { get; set; }
        public string IdType { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string Branch { get; set; }
    }
}
