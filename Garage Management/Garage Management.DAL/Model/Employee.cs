using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.DAL.Model
{
    public class Employee : Entity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string LicenseNo { get; set; }
        public int Age { get; set; }
        public long MobileNumber { get; set; }
        public string Address { get; set; }
        public string IdType { get; set; }
        public long IdNumber { get; set; }
        public long AccountNumber { get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string Branch { get; set; }


    }
}
