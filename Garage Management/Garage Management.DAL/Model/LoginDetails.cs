using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.DAL.Model
{
    public class LoginDetails : Entity
    {
        public string Password { get; set; }
        public string EmailId { get;set; }  
        public Guid EmployeeId { get; set; }

    }
}
