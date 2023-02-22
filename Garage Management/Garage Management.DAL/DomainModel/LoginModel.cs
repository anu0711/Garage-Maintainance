using Garage_Management.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.BAL.DomainModel
{
    public class LoginModel
    {
       
        public string Name { get; set; }
        public string LicenseNo { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string IdType { get; set; }
        public string IdNumber { get; set; }
        public string MobileNumber { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string Branch { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public Guid EmployeeId { get; set; }
    }
}
